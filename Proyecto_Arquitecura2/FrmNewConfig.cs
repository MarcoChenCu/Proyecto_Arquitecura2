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

        public FrmNewConfig()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            bool tiempo=false, temp=false, hum=false, lum=false;
            string error="";
            if (CbTiempo.SelectedItem == null)
            {
                tiempo = true;
                error +="\n - Tiempo";
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

            if (tiempo || temp || hum || lum)
            {
                MessageBox.Show("Existen errores en los siguientes campos: "+error,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Configuración guardada");
                this.Close();
            }

        }
    }
}
