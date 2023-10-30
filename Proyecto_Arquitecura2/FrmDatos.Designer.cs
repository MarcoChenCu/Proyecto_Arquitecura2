namespace Proyecto_Arquitecura2
{
    partial class FrmDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.bD_ProyectoDataSet = new Proyecto_Arquitecura2.BD_ProyectoDataSet();
            this.tbDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDatosTableAdapter = new Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters.TbDatosTableAdapter();
            this.tableAdapterManager = new Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters.TableAdapterManager();
            this.tbDatosDataGridView = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ProyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD_ProyectoDataSet
            // 
            this.bD_ProyectoDataSet.DataSetName = "BD_ProyectoDataSet";
            this.bD_ProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbDatosBindingSource
            // 
            this.tbDatosBindingSource.DataMember = "TbDatos";
            this.tbDatosBindingSource.DataSource = this.bD_ProyectoDataSet;
            // 
            // tbDatosTableAdapter
            // 
            this.tbDatosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TbConfigTableAdapter = null;
            this.tableAdapterManager.TbDatosTableAdapter = this.tbDatosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbDatosDataGridView
            // 
            this.tbDatosDataGridView.AllowUserToAddRows = false;
            this.tbDatosDataGridView.AllowUserToDeleteRows = false;
            this.tbDatosDataGridView.AllowUserToResizeColumns = false;
            this.tbDatosDataGridView.AllowUserToResizeRows = false;
            this.tbDatosDataGridView.AutoGenerateColumns = false;
            this.tbDatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbDatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tbDatosDataGridView.DataSource = this.tbDatosBindingSource;
            this.tbDatosDataGridView.Location = new System.Drawing.Point(126, 91);
            this.tbDatosDataGridView.Name = "tbDatosDataGridView";
            this.tbDatosDataGridView.RowHeadersVisible = false;
            this.tbDatosDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDatosDataGridView.Size = new System.Drawing.Size(543, 255);
            this.tbDatosDataGridView.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(126, 400);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chart1.Size = new System.Drawing.Size(543, 346);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lb1);
            this.panel1.Controls.Add(this.tbDatosDataGridView);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 681);
            this.panel1.TabIndex = 3;
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.ForeColor = System.Drawing.Color.SkyBlue;
            this.Lb1.Location = new System.Drawing.Point(341, 22);
            this.Lb1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(119, 40);
            this.Lb1.TabIndex = 3;
            this.Lb1.Text = "Datos";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDatos";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDatos";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ValorTemp";
            this.dataGridViewTextBoxColumn3.HeaderText = "Temperatura";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ValorHum";
            this.dataGridViewTextBoxColumn4.HeaderText = "Humedad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ValorLum";
            this.dataGridViewTextBoxColumn5.HeaderText = "Luminosidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaHora";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha y hora";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.FrmDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_ProyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BD_ProyectoDataSet bD_ProyectoDataSet;
        private System.Windows.Forms.BindingSource tbDatosBindingSource;
        private BD_ProyectoDataSetTableAdapters.TbDatosTableAdapter tbDatosTableAdapter;
        private BD_ProyectoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbDatosDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}