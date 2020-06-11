using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace PAYMETF
{
    public partial class EnviarReportes : Form
    {
        EnviosService envios = new EnviosService();
        Reportes reportes = new Reportes();
        public EnviarReportes()
        {
            InitializeComponent();
            txtemisor.Text = "Paymenttofeets@gmail.com";
            txtpasword.Text = "Pa123456";

          
        }

        private void EnviarReportes_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btnexaminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    txtadjuntar.Text = this.openFileDialog1.FileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: " + ex.ToString());
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportes.enviarCorreo(btrcuerpo.Text, txtasunto.Text, txtreceptor.Text, txtadjuntar.Text);
            envios.enviar(btrcuerpo.Text, txtasunto.Text, txtreceptor.Text, txtadjuntar.Text);
        }
    }
}
