namespace Proyecto_Arquitecura2
{
    partial class FrmNewConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbMinTemp = new System.Windows.Forms.TextBox();
            this.TbMaxTemp = new System.Windows.Forms.TextBox();
            this.TbMinHum = new System.Windows.Forms.TextBox();
            this.TbMaxHum = new System.Windows.Forms.TextBox();
            this.TbMinLum = new System.Windows.Forms.TextBox();
            this.TbMaxLum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.CbTiempo = new System.Windows.Forms.ComboBox();
            this.bD_ProyectoDataSet1 = new Proyecto_Arquitecura2.BD_ProyectoDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbConfigTableAdapter = new Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters.TbConfigTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ProyectoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(54, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(48, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temperatura mínima:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(300, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temperatura máxima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(48, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Humedad mímina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(300, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Humedad máxima:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(48, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Luminosidad mínima:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(301, 285);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Luminosidad máxima:";
            // 
            // TbNombre
            // 
            this.TbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbNombre.Location = new System.Drawing.Point(134, 106);
            this.TbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(125, 20);
            this.TbNombre.TabIndex = 8;
            this.TbNombre.TextChanged += new System.EventHandler(this.TbNombre_TextChanged);
            // 
            // TbMinTemp
            // 
            this.TbMinTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbMinTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMinTemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbMinTemp.Location = new System.Drawing.Point(191, 160);
            this.TbMinTemp.Margin = new System.Windows.Forms.Padding(2);
            this.TbMinTemp.Name = "TbMinTemp";
            this.TbMinTemp.Size = new System.Drawing.Size(69, 20);
            this.TbMinTemp.TabIndex = 10;
            // 
            // TbMaxTemp
            // 
            this.TbMaxTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbMaxTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMaxTemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbMaxTemp.Location = new System.Drawing.Point(455, 161);
            this.TbMaxTemp.Margin = new System.Windows.Forms.Padding(2);
            this.TbMaxTemp.Name = "TbMaxTemp";
            this.TbMaxTemp.Size = new System.Drawing.Size(68, 20);
            this.TbMaxTemp.TabIndex = 11;
            // 
            // TbMinHum
            // 
            this.TbMinHum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbMinHum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMinHum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbMinHum.Location = new System.Drawing.Point(191, 223);
            this.TbMinHum.Margin = new System.Windows.Forms.Padding(2);
            this.TbMinHum.Name = "TbMinHum";
            this.TbMinHum.Size = new System.Drawing.Size(68, 20);
            this.TbMinHum.TabIndex = 12;
            // 
            // TbMaxHum
            // 
            this.TbMaxHum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbMaxHum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMaxHum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbMaxHum.Location = new System.Drawing.Point(455, 223);
            this.TbMaxHum.Margin = new System.Windows.Forms.Padding(2);
            this.TbMaxHum.Name = "TbMaxHum";
            this.TbMaxHum.Size = new System.Drawing.Size(68, 20);
            this.TbMaxHum.TabIndex = 13;
            // 
            // TbMinLum
            // 
            this.TbMinLum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbMinLum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMinLum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbMinLum.Location = new System.Drawing.Point(191, 280);
            this.TbMinLum.Margin = new System.Windows.Forms.Padding(2);
            this.TbMinLum.Name = "TbMinLum";
            this.TbMinLum.Size = new System.Drawing.Size(68, 20);
            this.TbMinLum.TabIndex = 14;
            // 
            // TbMaxLum
            // 
            this.TbMaxLum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbMaxLum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMaxLum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TbMaxLum.Location = new System.Drawing.Point(455, 280);
            this.TbMaxLum.Margin = new System.Windows.Forms.Padding(2);
            this.TbMaxLum.Name = "TbMaxLum";
            this.TbMaxLum.Size = new System.Drawing.Size(68, 20);
            this.TbMaxLum.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(300, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tiempo de guardado:";
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Cooper Black", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.Color.SkyBlue;
            this.LbTitulo.Location = new System.Drawing.Point(128, 25);
            this.LbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(329, 35);
            this.LbTitulo.TabIndex = 17;
            this.LbTitulo.Text = "Crear Configuración";
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.ForeColor = System.Drawing.Color.Cyan;
            this.BtnCrear.Location = new System.Drawing.Point(173, 369);
            this.BtnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(103, 33);
            this.BtnCrear.TabIndex = 18;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = false;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Cyan;
            this.BtnSalir.Location = new System.Drawing.Point(309, 369);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(103, 33);
            this.BtnSalir.TabIndex = 19;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
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
            this.CbTiempo.Location = new System.Drawing.Point(455, 106);
            this.CbTiempo.Name = "CbTiempo";
            this.CbTiempo.Size = new System.Drawing.Size(68, 21);
            this.CbTiempo.TabIndex = 20;
            this.CbTiempo.Text = "1 min";
            // 
            // bD_ProyectoDataSet1
            // 
            this.bD_ProyectoDataSet1.DataSetName = "BD_ProyectoDataSet";
            this.bD_ProyectoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "TbConfig";
            this.bindingSource1.DataSource = this.bD_ProyectoDataSet1;
            // 
            // tbConfigTableAdapter
            // 
            this.tbConfigTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNewConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(576, 447);
            this.Controls.Add(this.CbTiempo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.LbTitulo);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmNewConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewConfig";
            this.Load += new System.EventHandler(this.FrmNewConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_ProyectoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbMinTemp;
        private System.Windows.Forms.TextBox TbMaxTemp;
        private System.Windows.Forms.TextBox TbMinHum;
        private System.Windows.Forms.TextBox TbMaxHum;
        private System.Windows.Forms.TextBox TbMinLum;
        private System.Windows.Forms.TextBox TbMaxLum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ComboBox CbTiempo;
        private BD_ProyectoDataSet bD_ProyectoDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BD_ProyectoDataSetTableAdapters.TbConfigTableAdapter tbConfigTableAdapter;
    }
}