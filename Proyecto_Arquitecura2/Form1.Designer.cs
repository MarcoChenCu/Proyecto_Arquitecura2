namespace Proyecto_Arquitecura2
{
    partial class Form1
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
            this.PbTemp = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbTitulo = new System.Windows.Forms.Label();
            this.CbConfiguraciones = new System.Windows.Forms.ComboBox();
            this.LbInfo = new System.Windows.Forms.Label();
            this.PbHumedad = new CircularProgressBar.CircularProgressBar();
            this.PbLuminosidad = new CircularProgressBar.CircularProgressBar();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Img1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PbTemp
            // 
            this.PbTemp.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.QuarticEaseOut;
            this.PbTemp.AnimationSpeed = 500;
            this.PbTemp.BackColor = System.Drawing.Color.Transparent;
            this.PbTemp.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.PbTemp.InnerColor = System.Drawing.Color.Transparent;
            this.PbTemp.InnerMargin = 2;
            this.PbTemp.InnerWidth = -1;
            this.PbTemp.Location = new System.Drawing.Point(64, 263);
            this.PbTemp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PbTemp.MarqueeAnimationSpeed = 2000;
            this.PbTemp.Name = "PbTemp";
            this.PbTemp.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.PbTemp.OuterMargin = -35;
            this.PbTemp.OuterWidth = 35;
            this.PbTemp.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(32)))));
            this.PbTemp.ProgressWidth = 25;
            this.PbTemp.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbTemp.Size = new System.Drawing.Size(155, 155);
            this.PbTemp.StartAngle = 90;
            this.PbTemp.SubscriptColor = System.Drawing.Color.White;
            this.PbTemp.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.PbTemp.SubscriptText = "";
            this.PbTemp.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PbTemp.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PbTemp.SuperscriptText = "";
            this.PbTemp.TabIndex = 0;
            this.PbTemp.Text = "--";
            this.PbTemp.TextMargin = new System.Windows.Forms.Padding(2, 4, 0, 0);
            this.PbTemp.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.Color.SkyBlue;
            this.LbTitulo.Location = new System.Drawing.Point(318, 41);
            this.LbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(353, 40);
            this.LbTitulo.TabIndex = 2;
            this.LbTitulo.Text = "Medidor ambiental";
            // 
            // CbConfiguraciones
            // 
            this.CbConfiguraciones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbConfiguraciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CbConfiguraciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbConfiguraciones.ForeColor = System.Drawing.Color.Cyan;
            this.CbConfiguraciones.FormattingEnabled = true;
            this.CbConfiguraciones.Items.AddRange(new object[] {
            "Rosas",
            "Girasoles"});
            this.CbConfiguraciones.Location = new System.Drawing.Point(372, 109);
            this.CbConfiguraciones.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbConfiguraciones.Name = "CbConfiguraciones";
            this.CbConfiguraciones.Size = new System.Drawing.Size(228, 21);
            this.CbConfiguraciones.TabIndex = 3;
            // 
            // LbInfo
            // 
            this.LbInfo.AutoSize = true;
            this.LbInfo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LbInfo.Location = new System.Drawing.Point(825, 524);
            this.LbInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbInfo.Name = "LbInfo";
            this.LbInfo.Size = new System.Drawing.Size(40, 17);
            this.LbInfo.TabIndex = 4;
            this.LbInfo.Text = "----";
            // 
            // PbHumedad
            // 
            this.PbHumedad.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.QuarticEaseOut;
            this.PbHumedad.AnimationSpeed = 500;
            this.PbHumedad.BackColor = System.Drawing.Color.Transparent;
            this.PbHumedad.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbHumedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.PbHumedad.InnerColor = System.Drawing.Color.Transparent;
            this.PbHumedad.InnerMargin = 2;
            this.PbHumedad.InnerWidth = -1;
            this.PbHumedad.Location = new System.Drawing.Point(372, 263);
            this.PbHumedad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PbHumedad.MarqueeAnimationSpeed = 2000;
            this.PbHumedad.Name = "PbHumedad";
            this.PbHumedad.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.PbHumedad.OuterMargin = -35;
            this.PbHumedad.OuterWidth = 35;
            this.PbHumedad.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.PbHumedad.ProgressWidth = 25;
            this.PbHumedad.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbHumedad.Size = new System.Drawing.Size(155, 155);
            this.PbHumedad.StartAngle = 90;
            this.PbHumedad.SubscriptColor = System.Drawing.Color.White;
            this.PbHumedad.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.PbHumedad.SubscriptText = "";
            this.PbHumedad.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PbHumedad.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PbHumedad.SuperscriptText = "";
            this.PbHumedad.TabIndex = 5;
            this.PbHumedad.Text = "--";
            this.PbHumedad.TextMargin = new System.Windows.Forms.Padding(2, 4, 0, 0);
            this.PbHumedad.Value = 68;
            // 
            // PbLuminosidad
            // 
            this.PbLuminosidad.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.QuarticEaseOut;
            this.PbLuminosidad.AnimationSpeed = 500;
            this.PbLuminosidad.BackColor = System.Drawing.Color.Transparent;
            this.PbLuminosidad.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbLuminosidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.PbLuminosidad.InnerColor = System.Drawing.Color.Transparent;
            this.PbLuminosidad.InnerMargin = 2;
            this.PbLuminosidad.InnerWidth = -1;
            this.PbLuminosidad.Location = new System.Drawing.Point(655, 263);
            this.PbLuminosidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PbLuminosidad.MarqueeAnimationSpeed = 2000;
            this.PbLuminosidad.Name = "PbLuminosidad";
            this.PbLuminosidad.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.PbLuminosidad.OuterMargin = -35;
            this.PbLuminosidad.OuterWidth = 35;
            this.PbLuminosidad.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(56)))));
            this.PbLuminosidad.ProgressWidth = 25;
            this.PbLuminosidad.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbLuminosidad.Size = new System.Drawing.Size(155, 155);
            this.PbLuminosidad.StartAngle = 90;
            this.PbLuminosidad.SubscriptColor = System.Drawing.Color.White;
            this.PbLuminosidad.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.PbLuminosidad.SubscriptText = "";
            this.PbLuminosidad.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PbLuminosidad.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PbLuminosidad.SuperscriptText = "";
            this.PbLuminosidad.TabIndex = 8;
            this.PbLuminosidad.Text = "--";
            this.PbLuminosidad.TextMargin = new System.Windows.Forms.Padding(2, 4, 0, 0);
            this.PbLuminosidad.Value = 68;
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.ForeColor = System.Drawing.Color.Cyan;
            this.BtnCrear.Location = new System.Drawing.Point(301, 506);
            this.BtnCrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(156, 48);
            this.BtnCrear.TabIndex = 9;
            this.BtnCrear.Text = "Crear configuración";
            this.BtnCrear.UseVisualStyleBackColor = false;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdmin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin.ForeColor = System.Drawing.Color.Cyan;
            this.BtnAdmin.Location = new System.Drawing.Point(506, 506);
            this.BtnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(156, 48);
            this.BtnAdmin.TabIndex = 10;
            this.BtnAdmin.Text = "Administrar";
            this.BtnAdmin.UseVisualStyleBackColor = false;
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.Color.Transparent;
            this.BtnMin.BackgroundImage = global::Proyecto_Arquitecura2.Properties.Resources.min;
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMin.Location = new System.Drawing.Point(903, 8);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(23, 23);
            this.BtnMin.TabIndex = 12;
            this.BtnMin.TabStop = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.BackgroundImage = global::Proyecto_Arquitecura2.Properties.Resources.x;
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrar.Location = new System.Drawing.Point(930, 8);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 23);
            this.BtnCerrar.TabIndex = 11;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Proyecto_Arquitecura2.Properties.Resources._2179;
            this.pictureBox2.Location = new System.Drawing.Point(803, 201);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Img1
            // 
            this.Img1.BackColor = System.Drawing.Color.Transparent;
            this.Img1.Image = global::Proyecto_Arquitecura2.Properties.Resources._2179_removebg_preview;
            this.Img1.Location = new System.Drawing.Point(527, 201);
            this.Img1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Img1.Name = "Img1";
            this.Img1.Size = new System.Drawing.Size(73, 73);
            this.Img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img1.TabIndex = 1;
            this.Img1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Proyecto_Arquitecura2.Properties.Resources.temp;
            this.pictureBox1.Location = new System.Drawing.Point(193, 188);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(961, 575);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.PbLuminosidad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PbHumedad);
            this.Controls.Add(this.LbInfo);
            this.Controls.Add(this.CbConfiguraciones);
            this.Controls.Add(this.LbTitulo);
            this.Controls.Add(this.PbTemp);
            this.Controls.Add(this.Img1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar PbTemp;
        private System.Windows.Forms.PictureBox Img1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.ComboBox CbConfiguraciones;
        private System.Windows.Forms.Label LbInfo;
        private CircularProgressBar.CircularProgressBar PbHumedad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar PbLuminosidad;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnMin;
    }
}

