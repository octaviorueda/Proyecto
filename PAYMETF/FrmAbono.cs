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
    public partial class FrmAbono : Form
    {
        Credito Credito;
        Cliente cliente;

        CarteraService carteraService;
        ClienteService clienteService;
        CreditoService creditoService;
        PagoService pagoService;

        public FrmAbono()
        {
            InitializeComponent();
            lblCantidad.Text = "Cantidad...";
            cmbCuota.SelectedIndex = 0;
            carteraService = new CarteraService(ConfigConnection.connectionString);
            clienteService = new ClienteService(ConfigConnection.connectionString);
            creditoService = new CreditoService(ConfigConnection.connectionString);
            pagoService = new PagoService(ConfigConnection.connectionString);
        }
        public FrmAbono(Credito credito) 
        {
            InitializeComponent();
            carteraService = new CarteraService(ConfigConnection.connectionString);
            clienteService = new ClienteService(ConfigConnection.connectionString);
            creditoService = new CreditoService(ConfigConnection.connectionString);
            pagoService = new PagoService(ConfigConnection.connectionString);
            
        }
        private void Inicializar(Credito credito) 
        {
            PintarLabel();
        
        }
        private void PintarLabel()
        {
            txtInformacion.Text = $"identificcion: {Credito.IdCliente}, saldo restante :{Credito.Saldo},cuotas restante: {Credito.NumeroCuotas},valor cuota:{Credito.Cuota.ToString()}";
        }
        private void CambiarTextoCantidad() 
        {
            switch (cmbCuota.SelectedIndex)
            {
                case 0:
                    lblCantidad.Text = "Cantidad...";
                    break;
                case 1:
                    lblCantidad.Text = "Cantidad de cuotas a pagar ";
                    break;
                case 2:
                    lblCantidad.Text = "cantidad de dinero a pagar ";
                    break;

            }

        }

        private bool ValidarPagar()
        {
            if (ValidarNumero(txtCuotapagar.Text.Trim()))
            {
                MessageBox.Show("Cantidad a pagar erronea.");
                return false;
            }
            else
            {
                if (cmbCuota.SelectedIndex == 1)
                {
                    if (Convert.ToInt32(txtCuotapagar.Text.Trim()) > Credito.NumeroCuotas || Convert.ToInt32(txtCuotapagar.Text.Trim()) < 1)
                    {
                        MessageBox.Show("Cantidad de cuotas erroneo, No puede pagar mas de las cuotas que debe o ingresar una cantidad neativa.");
                        return false;
                    }
                }
                else
                {
                    if (Convert.ToDouble(txtCuotapagar.Text.Trim()) > Credito.Saldo || Convert.ToDouble(txtCuotapagar.Text.Trim()) < Credito.Cuota)
                    {
                        MessageBox.Show("Cantidad de dinero erroneo, no puede pagar mas de lo que debe ni menos del valor de una cuota");
                        return false;
                    }
                }
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


        private void Abonar()
        {
            if (ValidarAlAbonar())
            {
                Pago pago = new Pago
                {
                    Fecha = DateTime.Now,
                    IdCliente = Credito.IdCliente,
                    IdCredito = Credito.IdCredito
                };
                if (cmbCuota.SelectedIndex == 1)
                {
                    double cuota = Credito.Cuota;
                    Credito.Abonar(cmbCuota.Text, 0, Convert.ToInt32(txtCuotapagar.Text.Trim()));
                    pago.ValorPago = cuota * Convert.ToDouble(txtCuotapagar.Text.Trim());
                    carteraService.ActualizarDineroRestante(pago.ValorPago);
                }
                else
                {
                    Credito.Abonar(cmbCuota.Text, Convert.ToInt32(txtCuotapagar.Text.Trim()), 0);
                    pago.ValorPago = Convert.ToDouble(txtCuotapagar.Text.Trim());
                    carteraService.ActualizarDineroRestante(pago.ValorPago);
                }
                if (Credito.Saldo == 0)
                {
                    clienteService.ActualizarEstado(Credito.IdCliente);
                    carteraService.ActualizarCanttidadDeudoresMenos();
                }
                pagoService.RegistrarPago(pago);
                creditoService.ActualizarCredito(Credito);
                PintarLabel();
            }
        }
        private bool ValidarAlAbonar()
        {
            if (lblinfo.Text == "")
            {
                MessageBox.Show("Debe primero buscar a un cliente.");
                return false;
            }
            else
            {
                if (cmbCuota.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionar como abonara.");
                    return false;
                }
                else
                {
                    if (txtCuotapagar.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe ingresar La candidad de lo que abonara.");
                        return false;
                    }
                    else
                    {
                        return ValidarPagar();
                    }
                }
            }
        }

        private void Buscar()
        {
            if (ValidarAlBuscar())
            {
                if (clienteService.BuscarInformacion(txtIdentificacion.Text.Trim()))
                {
                    cliente = clienteService.InformacionCliente();
                    if (cliente.Estado == "Activo")
                    {
                        Credito = creditoService.BuscarCedito(cliente.Identificacion);
                        PintarLabel();
                    }
                    else
                    {
                        MessageBox.Show("Se encontro un cliente con esta identificacion pero no debe dinero en estos momentos.");
                    }

                }
                else
                {
                    MessageBox.Show("No existe un cliente con esa identificacion.");
                }
            }
        }


        private bool ValidarAlBuscar()
        {
            if (txtIdentificacion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la identtificacion del cliente");
                return false;
            }
            return true;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void FrmAbono_Load(object sender, EventArgs e)
        {

        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            Abonar();
        }

        private void cmbCuota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
