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
            this.tbConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_ProyectoDataSet = new Proyecto_Arquitecura2.BD_ProyectoDataSet();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.fKTbDatosIdConfi4BAC3F29BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbConfigTableAdapter = new Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters.TbConfigTableAdapter();
            this.tableAdapterManager = new Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters.TableAdapterManager();
            this.tbDatosTableAdapter = new Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters.TbDatosTableAdapter();
            this.CbTiempo = new System.Windows.Forms.ComboBox();
            this.TbMaxLum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TbMinLum = new System.Windows.Forms.TextBox();
            this.TbMaxHum = new System.Windows.Forms.TextBox();
            this.TbMinHum = new System.Windows.Forms.TextBox();
            this.TbMaxTemp = new System.Windows.Forms.TextBox();
            this.TbMinTemp = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbConfigDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ProyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTbDatosIdConfi4BAC3F29BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbConfigDataGridView
            // 
            this.tbConfigDataGridView.AllowUserToAddRows = false;
            this.tbConfigDataGridView.AllowUserToDeleteRows = false;
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
            this.tbConfigDataGridView.Location = new System.Drawing.Point(43, 116);
            this.tbConfigDataGridView.Name = "tbConfigDataGridView";
            this.tbConfigDataGridView.ReadOnly = true;
            this.tbConfigDataGridView.RowHeadersVisible = false;
            this.tbConfigDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConfigDataGridView.Size = new System.Drawing.Size(774, 223);
            this.tbConfigDataGridView.TabIndex = 1;
            this.tbConfigDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbConfigDataGridView_CellClick);
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
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MinTemp";
            this.dataGridViewTextBoxColumn3.HeaderText = "Min Temp";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaxTemp";
            this.dataGridViewTextBoxColumn4.HeaderText = "Max Temp";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MinHumedad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Min Humedad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaxHumedad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Max Humedad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MinLum";
            this.dataGridViewTextBoxColumn7.HeaderText = "Min Lum";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MaxLum";
            this.dataGridViewTextBoxColumn8.HeaderText = "Max Lum";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "tiempo";
            this.dataGridViewTextBoxColumn9.HeaderText = "tiempo (min)";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // tbConfigBindingSource
            // 
            this.tbConfigBindingSource.DataMember = "TbConfig";
            this.tbConfigBindingSource.DataSource = this.bD_ProyectoDataSet;
            // 
            // bD_ProyectoDataSet
            // 
            this.bD_ProyectoDataSet.DataSetName = "BD_ProyectoDataSet";
            this.bD_ProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.Color.SkyBlue;
            this.LbTitulo.Location = new System.Drawing.Point(288, 35);
            this.LbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(306, 40);
            this.LbTitulo.TabIndex = 3;
            this.LbTitulo.Text = "Configuraciones";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.Cyan;
            this.BtnUpdate.Location = new System.Drawing.Point(605, 374);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(156, 48);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Actualizar";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click_1);
            // 
            // fKTbDatosIdConfi4BAC3F29BindingSource
            // 
            this.fKTbDatosIdConfi4BAC3F29BindingSource.DataMember = "FK__TbDatos__IdConfi__4BAC3F29";
            this.fKTbDatosIdConfi4BAC3F29BindingSource.DataSource = this.tbConfigBindingSource;
            // 
            // tbConfigTableAdapter
            // 
            this.tbConfigTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.TbConfigTableAdapter = null;
            this.tableAdapterManager.TbDatosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbDatosTableAdapter
            // 
            this.tbDatosTableAdapter.ClearBeforeFill = true;
            // 
            // CbTiempo
            // 
            this.CbTiempo.AutoCompleteCustomSource.AddRange(new string[] {
            "1 min",
            "5 min",
            "20 min",
            "30 min ",
            "1 hr",
            "12 hr",
            "24 hr"});
            this.CbTiempo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CbTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CbTiempo.DisplayMember = "1 min";
            this.CbTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbTiempo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CbTiempo.FormattingEnabled = true;
            this.CbTiempo.Items.AddRange(new object[] {
            "1 min",
            "5 min",
            "15 min",
            "30 min",
            "1 hr",
            "12 hr",
            "24 hr"});
            this.CbTiempo.Location = new System.Drawing.Point(447, 374);
            this.CbTiempo.Name = "CbTiempo";
            this.CbTiempo.Size = new System.Drawing.Size(68, 21);
            this.CbTiempo.TabIndex = 36;
            this.CbTiempo.Text = "1 min";
            // 
            // TbMaxLum
            // 
            this.TbMaxLum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbMaxLum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMaxLum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbMaxLum.Location = new System.Drawing.Point(447, 548);
            this.TbMaxLum.Margin = new System.Windows.Forms.Padding(2);
            this.TbMaxLum.Name = "TbMaxLum";
            this.TbMaxLum.Size = new System.Drawing.Size(68, 20);
            this.TbMaxLum.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(292, 377);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Tiempo de guardado:";
            // 
            // TbMinLum
            // 
            this.TbMinLum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbMinLum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMinLum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbMinLum.Location = new System.Drawing.Point(183, 548);
            this.TbMinLum.Margin = new System.Windows.Forms.Padding(2);
            this.TbMinLum.Name = "TbMinLum";
            this.TbMinLum.Size = new System.Drawing.Size(68, 20);
            this.TbMinLum.TabIndex = 33;
            // 
            // TbMaxHum
            // 
            this.TbMaxHum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbMaxHum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMaxHum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbMaxHum.Location = new System.Drawing.Point(447, 491);
            this.TbMaxHum.Margin = new System.Windows.Forms.Padding(2);
            this.TbMaxHum.Name = "TbMaxHum";
            this.TbMaxHum.Size = new System.Drawing.Size(68, 20);
            this.TbMaxHum.TabIndex = 32;
            // 
            // TbMinHum
            // 
            this.TbMinHum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbMinHum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMinHum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbMinHum.Location = new System.Drawing.Point(183, 491);
            this.TbMinHum.Margin = new System.Windows.Forms.Padding(2);
            this.TbMinHum.Name = "TbMinHum";
            this.TbMinHum.Size = new System.Drawing.Size(68, 20);
            this.TbMinHum.TabIndex = 31;
            // 
            // TbMaxTemp
            // 
            this.TbMaxTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbMaxTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMaxTemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbMaxTemp.Location = new System.Drawing.Point(447, 429);
            this.TbMaxTemp.Margin = new System.Windows.Forms.Padding(2);
            this.TbMaxTemp.Name = "TbMaxTemp";
            this.TbMaxTemp.Size = new System.Drawing.Size(68, 20);
            this.TbMaxTemp.TabIndex = 30;
            // 
            // TbMinTemp
            // 
            this.TbMinTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbMinTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMinTemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbMinTemp.Location = new System.Drawing.Point(183, 428);
            this.TbMinTemp.Margin = new System.Windows.Forms.Padding(2);
            this.TbMinTemp.Name = "TbMinTemp";
            this.TbMinTemp.Size = new System.Drawing.Size(69, 20);
            this.TbMinTemp.TabIndex = 29;
            // 
            // TbNombre
            // 
            this.TbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbNombre.Location = new System.Drawing.Point(126, 374);
            this.TbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(125, 20);
            this.TbNombre.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(293, 553);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Luminosidad máxima:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(40, 548);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Luminosidad mínima:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(292, 496);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Humedad máxima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(40, 491);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Humedad mímina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(292, 431);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Temperatura máxima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(40, 429);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Temperatura mínima:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(46, 374);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Cyan;
            this.BtnDelete.Location = new System.Drawing.Point(605, 458);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(156, 48);
            this.BtnDelete.TabIndex = 37;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmViewConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.CbTiempo);
            this.Controls.Add(this.TbMaxLum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbMinLum);
            this.Controls.Add(this.TbMaxHum);
            this.Controls.Add(this.TbMinHum);
            this.Controls.Add(this.TbMaxTemp);
            this.Controls.Add(this.TbMinTemp);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.LbTitulo);
            this.Controls.Add(this.tbConfigDataGridView);
            this.Name = "FrmViewConfigs";
            this.Text = "FrmViewConfigs";
            this.Load += new System.EventHandler(this.FrmViewConfigs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbConfigDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ProyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTbDatosIdConfi4BAC3F29BindingSource)).EndInit();
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
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.BindingSource fKTbDatosIdConfi4BAC3F29BindingSource;
        private BD_ProyectoDataSetTableAdapters.TbDatosTableAdapter tbDatosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ComboBox CbTiempo;
        private System.Windows.Forms.TextBox TbMaxLum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbMinLum;
        private System.Windows.Forms.TextBox TbMaxHum;
        private System.Windows.Forms.TextBox TbMinHum;
        private System.Windows.Forms.TextBox TbMaxTemp;
        private System.Windows.Forms.TextBox TbMinTemp;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDelete;
    }
}