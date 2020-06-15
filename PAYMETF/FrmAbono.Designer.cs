namespace PAYMETF
{
    partial class FrmAbono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbono));
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblidentificacion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCuota = new System.Windows.Forms.ComboBox();
            this.txtCuotapagar = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblabono = new System.Windows.Forms.Label();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(235, 76);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(129, 20);
            this.txtIdentificacion.TabIndex = 1;
            // 
            // lblidentificacion
            // 
            this.lblidentificacion.AutoSize = true;
            this.lblidentificacion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidentificacion.Location = new System.Drawing.Point(121, 78);
            this.lblidentificacion.Name = "lblidentificacion";
            this.lblidentificacion.Size = new System.Drawing.Size(108, 15);
            this.lblidentificacion.TabIndex = 2;
            this.lblidentificacion.Text = "IDENTIFICACION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.cmbCuota);
            this.panel2.Controls.Add(this.txtCuotapagar);
            this.panel2.Controls.Add(this.lblCantidad);
            this.panel2.Controls.Add(this.lblabono);
            this.panel2.Controls.Add(this.txtInformacion);
            this.panel2.Controls.Add(this.lblinfo);
            this.panel2.Controls.Add(this.btnAbonar);
            this.panel2.Location = new System.Drawing.Point(9, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 164);
            this.panel2.TabIndex = 3;
            // 
            // cmbCuota
            // 
            this.cmbCuota.FormattingEnabled = true;
            this.cmbCuota.Items.AddRange(new object[] {
            "SELECIONE",
            "Cuotas"});
            this.cmbCuota.Location = new System.Drawing.Point(194, 49);
            this.cmbCuota.Name = "cmbCuota";
            this.cmbCuota.Size = new System.Drawing.Size(121, 21);
            this.cmbCuota.TabIndex = 6;
            this.cmbCuota.SelectedIndexChanged += new System.EventHandler(this.cmbCuota_SelectedIndexChanged);
            // 
            // txtCuotapagar
            // 
            this.txtCuotapagar.Location = new System.Drawing.Point(194, 84);
            this.txtCuotapagar.Name = "txtCuotapagar";
            this.txtCuotapagar.Size = new System.Drawing.Size(100, 20);
            this.txtCuotapagar.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(3, 84);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(185, 15);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "CANTIDAD DE CUOTA A PAGAR";
            // 
            // lblabono
            // 
            this.lblabono.AutoSize = true;
            this.lblabono.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblabono.Location = new System.Drawing.Point(58, 49);
            this.lblabono.Name = "lblabono";
            this.lblabono.Size = new System.Drawing.Size(130, 15);
            this.lblabono.TabIndex = 3;
            this.lblabono.Text = "QUE ABONA? CUOTA ";
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(194, 13);
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(379, 20);
            this.txtInformacion.TabIndex = 2;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(4, 16);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(184, 15);
            this.lblinfo.TabIndex = 1;
            this.lblinfo.Text = "INFORMACION ENCONTRADA";
            // 
            // btnAbonar
            // 
            this.btnAbonar.BackColor = System.Drawing.Color.White;
            this.btnAbonar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonar.Image = ((System.Drawing.Image)(resources.GetObject("btnAbonar.Image")));
            this.btnAbonar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbonar.Location = new System.Drawing.Point(627, 13);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(104, 120);
            this.btnAbonar.TabIndex = 0;
            this.btnAbonar.Text = "ABONAR";
            this.btnAbonar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbonar.UseVisualStyleBackColor = false;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(382, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 118);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(703, 368);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(94, 29);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmAbono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 518);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblidentificacion);
            this.Controls.Add(this.txtIdentificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAbono";
            this.Text = "`";
            this.Load += new System.EventHandler(this.FrmAbono_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblidentificacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCuota;
        private System.Windows.Forms.TextBox txtCuotapagar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblabono;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCerrar;
    }
}