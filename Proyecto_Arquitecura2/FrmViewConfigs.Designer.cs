namespace Proyecto_Arquitecura2
{
    partial class FrmViewConfigs
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
            this.tbConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbConfigTableAdapter = new Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters.TbConfigTableAdapter();
            this.tableAdapterManager = new Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters.TableAdapterManager();
            this.tbConfigDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LbTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ProyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConfigDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_ProyectoDataSet
            // 
            this.bD_ProyectoDataSet.DataSetName = "BD_ProyectoDataSet";
            this.bD_ProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbConfigBindingSource
            // 
            this.tbConfigBindingSource.DataMember = "TbConfig";
            this.tbConfigBindingSource.DataSource = this.bD_ProyectoDataSet;
            // 
            // tbConfigTableAdapter
            // 
            this.tbConfigTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TbConfigTableAdapter = this.tbConfigTableAdapter;
            this.tableAdapterManager.TbDatosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbConfigDataGridView
            // 
            this.tbConfigDataGridView.AutoGenerateColumns = false;
            this.tbConfigDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbConfigDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.tbConfigDataGridView.DataSource = this.tbConfigBindingSource;
            this.tbConfigDataGridView.Location = new System.Drawing.Point(34, 96);
            this.tbConfigDataGridView.Name = "tbConfigDataGridView";
            this.tbConfigDataGridView.RowHeadersVisible = false;
            this.tbConfigDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConfigDataGridView.Size = new System.Drawing.Size(774, 220);
            this.tbConfigDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdConfig";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdConfig";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreConfig";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MinTemp";
            this.dataGridViewTextBoxColumn3.HeaderText = "Min Temp";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaxTemp";
            this.dataGridViewTextBoxColumn4.HeaderText = "Max Temp";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MinHumedad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Min Humedad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaxHumedad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Max Humedad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MinLum";
            this.dataGridViewTextBoxColumn7.HeaderText = "Min Lum";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MaxLum";
            this.dataGridViewTextBoxColumn8.HeaderText = "Max Lum";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "tiempo";
            this.dataGridViewTextBoxColumn9.HeaderText = "tiempo (min)";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.Color.SkyBlue;
            this.LbTitulo.Location = new System.Drawing.Point(265, 25);
            this.LbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(306, 40);
            this.LbTitulo.TabIndex = 3;
            this.LbTitulo.Text = "Configuraciones";
            // 
            // FrmViewConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.LbTitulo);
            this.Controls.Add(this.tbConfigDataGridView);
            this.Name = "FrmViewConfigs";
            this.Text = "FrmViewConfigs";
            this.Load += new System.EventHandler(this.FrmViewConfigs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_ProyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConfigDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_ProyectoDataSet bD_ProyectoDataSet;
        private System.Windows.Forms.BindingSource tbConfigBindingSource;
        private BD_ProyectoDataSetTableAdapters.TbConfigTableAdapter tbConfigTableAdapter;
        private BD_ProyectoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbConfigDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label LbTitulo;
    }
}