using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAYMETF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            LbFecha.Text = DateTime.Now.ToLongDateString();
            LbHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void abrirfrom(object agregarForm)
        {
            if (this.panelprimciapla.Controls.Count > 0) this.panelprimciapla.Controls.RemoveAt(0);
            Form form = agregarForm as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelprimciapla.Controls.Add(form);
            this.panelprimciapla.Tag = form;
            form.Show();
        
        
        }




        private void btnAbono_Click(object sender, EventArgs e)
        {

            abrirfrom( new FrmAbono());

        }

        private void btnCartera_Click(object sender, EventArgs e)
        {

            abrirfrom(new FrmCartera());

        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            abrirfrom(new FrmRegistrar());

        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            abrirfrom(new FrmInformacionUsuario());

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LbHora_Click(object sender, EventArgs e)
        {

        }
    }
}
