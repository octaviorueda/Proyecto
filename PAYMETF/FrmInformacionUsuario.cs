using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;
namespace PAYMETF
{
    public partial class FrmInformacionUsuario : Form
    {

        Cliente cliente;
        Credito Credito;
        ClienteService clienteService;
        CreditoService creditoService;

        public FrmInformacionUsuario()
        {
            InitializeComponent();
            clienteService = new ClienteService(ConfigConnection.connectionString);
            creditoService = new CreditoService(ConfigConnection.connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            Abonar();
        }








        private void Abonar()
        {
            if (ValidarCampos(2))
            {
                FrmAbono abono = new FrmAbono(Credito);
                abono.ShowDialog();
                Buscar();
            }
        }
        private void Buscar()
        {
            if (ValidarCampos(1))
            {
                if (clienteService.BuscarInformacion(txtIdentificacion.Text.Trim()))
                {
                    cliente = clienteService.InformacionCliente();
                    txtIdentificacion.Text = cliente.Identificacion;
                    txtCorreo.Text = cliente.Correo;
                    txtDireccion.Text = cliente.Direccion;
                    txtNombre.Text = cliente.Nombre;
                    txtTelefono.Text = cliente.Telefono;
                    txtEstado.Text = cliente.Estado;
                    if (cliente.Estado == "Activo")
                    {
                        Credito = creditoService.BuscarCedito(cliente.Identificacion);
                        txtCuotasrestantes.Text = Credito.NumeroCuotas.ToString();
                        txtValorcuotas.Text = Credito.Cuota.ToString();
                        txtSaldorestante.Text = Credito.Saldo.ToString();
                    }
                    else
                    {
                        txtCuotasrestantes.Text = "No debe dinero.";
                        txtSaldorestante.Text = "No debe dinero.";
                        txtValorcuotas.Text = "No debe dinero.";
                    }
                }
                else
                {
                    MessageBox.Show("No existe un cliente registrado con esa identificacion.");
                }

            }
        }
        private bool ValidarCampos(int campos)
        {
            switch (campos)
            {
                case 1:
                    if (ValidarNumero(txtIdentificacion.Text.Trim()))
                    {
                        MessageBox.Show("Identificacion erronea.");
                        return false;
                    }
                    else
                    {
                        if (txtIdentificacion.Text.Trim().Length < 7 || txtIdentificacion.Text.Trim().Length > 11)
                        {
                            MessageBox.Show("Identificacion erronea.");
                            return false;
                        }
                    }
                    return true;
                case 2:
                    if (txtid.Text == "")
                    {
                        MessageBox.Show("Debe buscar primero.");
                        return false;
                    }
                    return true;
            }
            return true;
        }
        private bool ValidarNumero(String Numero)
        {
            bool EsNumero;
            EsNumero = Double.TryParse(Convert.ToString(Numero),
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out _);
            return !EsNumero;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnAplicarinteres_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(2))
            {
                Credito.AplicarInteres();
                Buscar();

            }
        }
    }
}
