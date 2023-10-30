using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Arquitecura2
{
    public partial class FrmNewConfig : Form
    {
        int[] Tiempos = new int[] { 1, 5, 15, 30, 60, 720, 1440};
        int? name;
        public FrmNewConfig()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public event EventHandler ChildFormClosed;

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            ChildFormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            bool tiempo=false, temp=false, hum=false, lum=false,NombreExistente=false;
            string error="";
            if (CbTiempo.SelectedItem == null)
            {
                tiempo = true;
                error +="\n - Tiempo";
            }
            if (name!=null)
            {
                NombreExistente = true;
                error += "\n - Configuración existente con este nombre";
            }
            if(TbMinTemp.Text == "" || TbMaxTemp.Text=="" || Convert.ToDouble(TbMaxTemp.Text)<=Convert.ToDouble(TbMinTemp.Text))
            {
                temp = true;
                error += "\n - Rango de temperatura";
            }
            if (TbMinHum.Text == "" || TbMaxHum.Text == "" || Convert.ToDouble(TbMaxHum.Text) <= Convert.ToDouble(TbMinHum.Text))
            {
                hum = true;
                error += "\n - Rango de humedad";
            }
            if (TbMinLum.Text == "" || TbMaxLum.Text == "" || Convert.ToDouble(TbMaxLum.Text) <= Convert.ToDouble(TbMinLum.Text))
            {
                lum = true;
                error += "\n - Rango de luminosidad";
            }

            if (tiempo || temp || hum || lum || NombreExistente)
            {
                MessageBox.Show("Existen errores en los siguientes campos: "+error,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                InsertarBD(TbNombre.Text, Convert.ToSingle(TbMinTemp.Text), Convert.ToSingle(TbMaxTemp.Text), Convert.ToSingle(TbMinHum.Text), Convert.ToSingle(TbMaxHum.Text), Convert.ToSingle(TbMinLum.Text), Convert.ToSingle(TbMaxLum.Text), Tiempos[CbTiempo.SelectedIndex]);
            }

        }

        private void InsertarBD(string nombre,float MinTemp,float MaxTemp, float MinHum,float MaxHum,float MinLum,float MaxLum, int tiempo)
        {
            try
            {
                tbConfigTableAdapter.InsertConf(nombre, MinTemp, MaxTemp, MinHum, MaxHum, MinLum, MaxLum, tiempo);
                MessageBox.Show("Configuración guardada");
            }
            catch
            {
                MessageBox.Show("Error al guardar la configuración\nContacte al ingeniero más cercano","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FrmNewConfig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_ProyectoDataSet1.TbConfig' table. You can move, or remove it, as needed.
            this.tbConfigTableAdapter.Fill(this.bD_ProyectoDataSet1.TbConfig);

        }

        private void TbNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                name = tbConfigTableAdapter.CheckNombres(TbNombre.Text);
            }catch{}
        }
    }
}
