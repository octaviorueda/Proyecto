namespace PAYMETF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.btnCartera = new System.Windows.Forms.Button();
            this.btnAbono = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelprimciapla = new System.Windows.Forms.Panel();
            this.LbFecha = new System.Windows.Forms.Label();
            this.LbHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.btnPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnPrestamo.Image")));
            this.btnPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamo.Location = new System.Drawing.Point(12, 251);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(231, 31);
            this.btnPrestamo.TabIndex = 0;
            this.btnPrestamo.Text = "NUEVO PRESTAMO";
            this.btnPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrestamo.UseVisualStyleBackColor = false;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnCartera
            // 
            this.btnCartera.BackColor = System.Drawing.Color.Transparent;
            this.btnCartera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartera.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCartera.Image = ((System.Drawing.Image)(resources.GetObject("btnCartera.Image")));
            this.btnCartera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartera.Location = new System.Drawing.Point(12, 345);
            this.btnCartera.Name = "btnCartera";
            this.btnCartera.Size = new System.Drawing.Size(231, 31);
            this.btnCartera.TabIndex = 1;
            this.btnCartera.Text = "CARTERA";
            this.btnCartera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCartera.UseVisualStyleBackColor = false;
            this.btnCartera.Click += new System.EventHandler(this.btnCartera_Click);
            // 
            // btnAbono
            // 
            this.btnAbono.BackColor = System.Drawing.Color.Transparent;
            this.btnAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbono.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAbono.Image = ((System.Drawing.Image)(resources.GetObject("btnAbono.Image")));
            this.btnAbono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbono.Location = new System.Drawing.Point(12, 298);
            this.btnAbono.Name = "btnAbono";
            this.btnAbono.Size = new System.Drawing.Size(231, 31);
            this.btnAbono.TabIndex = 2;
            this.btnAbono.Text = "NUEVO ABONO";
            this.btnAbono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbono.UseVisualStyleBackColor = false;
            this.btnAbono.Click += new System.EventHandler(this.btnAbono_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInformacion.BackColor = System.Drawing.Color.Transparent;
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInformacion.Image = ((System.Drawing.Image)(resources.GetObject("btnInformacion.Image")));
            this.btnInformacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformacion.Location = new System.Drawing.Point(12, 391);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(231, 31);
            this.btnInformacion.TabIndex = 3;
            this.btnInformacion.Text = "INFORMACION CLIENTE";
            this.btnInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInformacion.UseVisualStyleBackColor = false;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 29);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1035, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1062, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.btnPrestamo);
            this.panel2.Controls.Add(this.LbHora);
            this.panel2.Controls.Add(this.LbFecha);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnInformacion);
            this.panel2.Controls.Add(this.btnCartera);
            this.panel2.Controls.Add(this.btnAbono);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 518);
            this.panel2.TabIndex = 7;
            // 
            // panelprimciapla
            // 
            this.panelprimciapla.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelprimciapla.Location = new System.Drawing.Point(249, 29);
            this.panelprimciapla.Name = "panelprimciapla";
            this.panelprimciapla.Size = new System.Drawing.Size(838, 518);
            this.panelprimciapla.TabIndex = 8;
            this.panelprimciapla.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbFecha.Location = new System.Drawing.Point(12, 196);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(48, 15);
            this.LbFecha.TabIndex = 5;
            this.LbFecha.Text = "FECHA";
            // 
            // LbHora
            // 
            this.LbHora.AutoSize = true;
            this.LbHora.BackColor = System.Drawing.Color.Transparent;
            this.LbHora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbHora.Location = new System.Drawing.Point(11, 211);
            this.LbHora.Name = "LbHora";
            this.LbHora.Size = new System.Drawing.Size(56, 19);
            this.LbHora.TabIndex = 6;
            this.LbHora.Text = "HORA";
            this.LbHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbHora.Click += new System.EventHandler(this.LbHora_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 547);
            this.Controls.Add(this.panelprimciapla);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Button btnCartera;
        private System.Windows.Forms.Button btnAbono;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelprimciapla;
        private System.Windows.Forms.Label LbFecha;
        private System.Windows.Forms.Label LbHora;
    }
}

