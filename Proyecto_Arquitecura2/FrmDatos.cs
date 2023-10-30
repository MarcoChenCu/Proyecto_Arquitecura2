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
    public partial class FrmDatos : Form
    {
        int ID;
        public FrmDatos(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }     

        private void tbDatosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbDatosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_ProyectoDataSet);

        }

        private void FrmDatos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_ProyectoDataSet.TbDatos' table. You can move, or remove it, as needed.


        }
    }
}
