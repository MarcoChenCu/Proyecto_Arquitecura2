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
            this.bD_ProyectoDataSet = new Proyecto_Arquitecura2.BD_ProyectoDataSet();
            this.tbDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDatosTableAdapter = new Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters.TbDatosTableAdapter();
            this.tableAdapterManager = new Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters.TableAdapterManager();
            this.tbDatosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ProyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatosDataGridView)).BeginInit();
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
            this.tbDatosDataGridView.AutoGenerateColumns = false;
            this.tbDatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbDatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tbDatosDataGridView.DataSource = this.tbDatosBindingSource;
            this.tbDatosDataGridView.Location = new System.Drawing.Point(73, 34);
            this.tbDatosDataGridView.Name = "tbDatosDataGridView";
            this.tbDatosDataGridView.Size = new System.Drawing.Size(643, 255);
            this.tbDatosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDatos";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDatos";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdConfig";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdConfig";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ValorTemp";
            this.dataGridViewTextBoxColumn3.HeaderText = "ValorTemp";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ValorHum";
            this.dataGridViewTextBoxColumn4.HeaderText = "ValorHum";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ValorLum";
            this.dataGridViewTextBoxColumn5.HeaderText = "ValorLum";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaHora";
            this.dataGridViewTextBoxColumn6.HeaderText = "FechaHora";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.tbDatosDataGridView);
            this.Name = "FrmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.FrmDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_ProyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BD_ProyectoDataSet bD_ProyectoDataSet;
        private System.Windows.Forms.BindingSource tbDatosBindingSource;
        private BD_ProyectoDataSetTableAdapters.TbDatosTableAdapter tbDatosTableAdapter;
        private BD_ProyectoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbDatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}