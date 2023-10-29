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
    public partial class FrmViewConfigs : Form
    {
        public FrmViewConfigs()
        {
            InitializeComponent();
        }

        private void tbConfigBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbConfigBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_ProyectoDataSet);

        }

        private void FrmViewConfigs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_ProyectoDataSet.TbConfig' table. You can move, or remove it, as needed.
            this.tbConfigTableAdapter.Fill(this.bD_ProyectoDataSet.TbConfig);

        }
    }
}
