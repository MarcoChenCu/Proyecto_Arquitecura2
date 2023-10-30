using Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            tbDatosTableAdapter.GetDatos(bD_ProyectoDataSet.TbDatos, ID);
            Graficar();
        }

        private void Graficar()
        {
            //Generate siries bar chart whith the data of the second column of the table
            chart1.Series.Clear(); // Borra cualquier serie previa

            // Crear una nueva serie para el gráfico de líneas
            Series series = new Series("Temperatura");
            Series series1 = new Series("Humedad");
            Series series2 = new Series("Luminosidad");
            series.ChartType = SeriesChartType.Line;

            // Recorre las filas del DataGridView y agrega los datos al Chart
            foreach (DataGridViewRow row in tbDatosDataGridView.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value!=null) // La segunda columna es la columna de temperatura
                {
                    double temperatura = Convert.ToDouble(row.Cells[1].Value);
                    series.Points.AddY(temperatura);
                    double humedad = Convert.ToDouble(row.Cells[2].Value);
                    series1.Points.AddY(humedad);
                    double luminosidad = Convert.ToDouble(row.Cells[3].Value);
                    series2.Points.AddY(luminosidad);
                }
            }

            chart1.Series.Add(series);
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);

        }
    }
}
