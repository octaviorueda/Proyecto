namespace PAYMETF
{
    partial class Filtross
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
            this.datafiltros = new System.Windows.Forms.DataGridView();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtidentificcion = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbinformacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncargarinfo = new System.Windows.Forms.Button();
            this.datostodos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.btncargarclietes = new System.Windows.Forms.Button();
            this.btncargarfecha = new System.Windows.Forms.Button();
            this.comboinformacion2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotales = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datafiltros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datostodos)).BeginInit();
            this.SuspendLayout();
            // 
            // datafiltros
            // 
            this.datafiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datafiltros.Location = new System.Drawing.Point(51, 217);
            this.datafiltros.Name = "datafiltros";
            this.datafiltros.Size = new System.Drawing.Size(759, 221);
            this.datafiltros.TabIndex = 0;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(119, 39);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(121, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // txtidentificcion
            // 
            this.txtidentificcion.Location = new System.Drawing.Point(119, 75);
            this.txtidentificcion.Name = "txtidentificcion";
            this.txtidentificcion.Size = new System.Drawing.Size(121, 20);
            this.txtidentificcion.TabIndex = 4;
            this.txtidentificcion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(487, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "IDENTIFICACION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "NOMBRE";
            // 
            // cmbinformacion
            // 
            this.cmbinformacion.FormattingEnabled = true;
            this.cmbinformacion.Items.AddRange(new object[] {
            "pagos",
            "creditos"});
            this.cmbinformacion.Location = new System.Drawing.Point(119, 110);
            this.cmbinformacion.Name = "cmbinformacion";
            this.cmbinformacion.Size = new System.Drawing.Size(121, 21);
            this.cmbinformacion.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "INFORMACION";
            // 
            // btncargarinfo
            // 
            this.btncargarinfo.BackColor = System.Drawing.Color.Blue;
            this.btncargarinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargarinfo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargarinfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncargarinfo.Location = new System.Drawing.Point(119, 147);
            this.btncargarinfo.Name = "btncargarinfo";
            this.btncargarinfo.Size = new System.Drawing.Size(100, 23);
            this.btncargarinfo.TabIndex = 12;
            this.btncargarinfo.Text = "CARGAR INFO";
            this.btncargarinfo.UseVisualStyleBackColor = false;
            // 
            // datostodos
            // 
            this.datostodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datostodos.Location = new System.Drawing.Point(246, 35);
            this.datostodos.Name = "datostodos";
            this.datostodos.Size = new System.Drawing.Size(564, 150);
            this.datostodos.TabIndex = 13;
            this.datostodos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datostodos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ESTADO";
            // 
            // cmbestado
            // 
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "todos"});
            this.cmbestado.Location = new System.Drawing.Point(468, 8);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 21);
            this.cmbestado.TabIndex = 15;
            // 
            // btncargarclietes
            // 
            this.btncargarclietes.BackColor = System.Drawing.Color.Blue;
            this.btncargarclietes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargarclietes.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargarclietes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncargarclietes.Location = new System.Drawing.Point(595, 6);
            this.btncargarclietes.Name = "btncargarclietes";
            this.btncargarclietes.Size = new System.Drawing.Size(153, 23);
            this.btncargarclietes.TabIndex = 16;
            this.btncargarclietes.Text = "CARGAR CLIENTES";
            this.btncargarclietes.UseVisualStyleBackColor = false;
            this.btncargarclietes.Click += new System.EventHandler(this.btncargarclietes_Click);
            // 
            // btncargarfecha
            // 
            this.btncargarfecha.BackColor = System.Drawing.Color.Blue;
            this.btncargarfecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargarfecha.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargarfecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncargarfecha.Location = new System.Drawing.Point(693, 189);
            this.btncargarfecha.Name = "btncargarfecha";
            this.btncargarfecha.Size = new System.Drawing.Size(75, 23);
            this.btncargarfecha.TabIndex = 17;
            this.btncargarfecha.Text = "CARGAR ";
            this.btncargarfecha.UseVisualStyleBackColor = false;
            // 
            // comboinformacion2
            // 
            this.comboinformacion2.FormattingEnabled = true;
            this.comboinformacion2.Items.AddRange(new object[] {
            "pagos ",
            "creditos"});
            this.comboinformacion2.Location = new System.Drawing.Point(360, 191);
            this.comboinformacion2.Name = "comboinformacion2";
            this.comboinformacion2.Size = new System.Drawing.Size(121, 21);
            this.comboinformacion2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "INFORMACION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(262, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "TOTAL";
            // 
            // txttotales
            // 
            this.txttotales.Location = new System.Drawing.Point(311, 444);
            this.txttotales.Name = "txttotales";
            this.txttotales.Size = new System.Drawing.Size(100, 20);
            this.txttotales.TabIndex = 21;
            // 
            // Filtross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(822, 479);
            this.Controls.Add(this.txttotales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboinformacion2);
            this.Controls.Add(this.btncargarfecha);
            this.Controls.Add(this.btncargarclietes);
            this.Controls.Add(this.cmbestado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datostodos);
            this.Controls.Add(this.btncargarinfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbinformacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtidentificcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.datafiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Filtross";
            this.Text = "Filtross";
            ((System.ComponentModel.ISupportInitialize)(this.datafiltros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datostodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datafiltros;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtidentificcion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbinformacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncargarinfo;
        private System.Windows.Forms.DataGridView datostodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Button btncargarclietes;
        private System.Windows.Forms.Button btncargarfecha;
        private System.Windows.Forms.ComboBox comboinformacion2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotales;
    }
}