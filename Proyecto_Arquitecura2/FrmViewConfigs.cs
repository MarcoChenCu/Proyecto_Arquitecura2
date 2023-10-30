using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Arquitecura2
{
    public partial class FrmViewConfigs : Form
    {
        int ID = 0;
        string nombre;
        double minTem, maxTem, minHume, maxHume, minLum, maxLum;
        int tiempo;
        int[] Tiempos = new int[] { 1, 5, 15, 30, 60, 720, 1440 };
        public FrmViewConfigs()
        {
            InitializeComponent();
        }
        public event EventHandler ChildFormClosed;

        
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            ChildFormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void tbConfigBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbConfigBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_ProyectoDataSet);

        }

        private void FrmViewConfigs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_ProyectoDataSet.TbDatos' table. You can move, or remove it, as needed.
            this.tbDatosTableAdapter.Fill(this.bD_ProyectoDataSet.TbDatos);
            // TODO: This line of code loads data into the 'bD_ProyectoDataSet.TbConfig' table. You can move, or remove it, as needed.
            this.tbConfigTableAdapter.Fill(this.bD_ProyectoDataSet.TbConfig);

        }

        private void tbConfigDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(tbConfigDataGridView.Rows[tbConfigDataGridView.CurrentCell.RowIndex].Cells[0].Value);
            TbNombre.Text = tbConfigDataGridView.Rows[tbConfigDataGridView.CurrentRow.Index].Cells[1].Value.ToString();
            TbMinTemp.Text = tbConfigDataGridView.Rows[tbConfigDataGridView.CurrentRow.Index].Cells[2].Value.ToString();
            TbMaxTemp.Text = tbConfigDataGridView.Rows[tbConfigDataGridView.CurrentRow.Index].Cells[3].Value.ToString();
            TbMinHum.Text = tbConfigDataGridView.Rows[tbConfigDataGridView.CurrentRow.Index].Cells[4].Value.ToString();
            TbMaxHum.Text = tbConfigDataGridView.Rows[tbConfigDataGridView.CurrentRow.Index].Cells[5].Value.ToString();
            TbMinLum.Text = tbConfigDataGridView.Rows[tbConfigDataGridView.CurrentRow.Index].Cells[6].Value.ToString();
            TbMaxLum.Text = tbConfigDataGridView.Rows[tbConfigDataGridView.CurrentRow.Index].Cells[7].Value.ToString();
            CbTiempo.Text = tbConfigDataGridView.Rows[tbConfigDataGridView.CurrentRow.Index].Cells[8].Value.ToString();
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                nombre = TbNombre.Text;
                minTem = Convert.ToDouble(TbMinTemp.Text);
                maxTem = Convert.ToDouble(TbMaxTemp.Text);
                minHume = Convert.ToDouble(TbMinHum.Text);
                maxHume = Convert.ToDouble(TbMaxHum.Text);
                minLum = Convert.ToDouble(TbMinLum.Text);
                maxLum = Convert.ToDouble(TbMaxLum.Text);
                tiempo = Tiempos[CbTiempo.SelectedIndex];

                int id = Convert.ToInt32(this.tbConfigTableAdapter.GetID(nombre));

                this.tbConfigTableAdapter.UCong(nombre, minTem, maxTem, minHume, maxHume, minLum, maxLum, tiempo, id);
                this.tbConfigTableAdapter.Fill(this.bD_ProyectoDataSet.TbConfig);
                MessageBox.Show("Configuracion Actualizada");
                
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("SELECCIONE UNA CONFIGURACION PARA ELIMINAR", "MEDIDOR AMBIENTAL", MessageBoxButtons.OK);
            }
            else
            {
                this.tbConfigTableAdapter.DeleteQuery(ID);
                this.tbConfigTableAdapter.Fill(this.bD_ProyectoDataSet.TbConfig);
                MessageBox.Show("Configuracion Eliminada");
                TbNombre.Text = "";
                TbMaxTemp.Text = "";
                TbMinTemp.Text = "";
                TbMaxHum.Text = ""; 
                TbMinHum.Text = ""; 
                TbMaxLum.Text = "";
                TbMinLum.Text = ""; 
                CbTiempo.Text = ""; 
                TbNombre.Focus();
            }
        }
    }
}
