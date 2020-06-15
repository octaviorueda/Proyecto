using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime;
using ENTITY;
using BLL;

namespace PAYMETF
{
    public partial class FrmRegistrar : Form
    {
        double Prestamo, ValorCuota;
        double CantidadCuotas;
        CarteraService carteraService;
        ClienteService clienteService;


        public FrmRegistrar()
        {
            InitializeComponent();
            carteraService = new CarteraService(ConfigConnection.connectionString);
            clienteService = new ClienteService(ConfigConnection.connectionString);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtValorcuota_TextChanged(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistrarPrestamo();
        }

        private void CalcularCuotas() 
        {
            double CantidadExacta;
            Prestamo = Convert.ToDouble(txtPrestamo.Text.Trim());
            CantidadCuotas = Convert.ToDouble(TxtcantidadCuota.Text.Trim());
            Prestamo = (Prestamo * 0.16)+Prestamo ;
            CantidadExacta =  Prestamo / CantidadCuotas;
            ValorCuota = Math.Floor(CantidadExacta);
            
            txtValorcuota.Text = ValorCuota.ToString();
        
        }

        private bool ValidarCampoPrestamo() 
        {
            if (txtIdentificacion.Text.Trim() == "")
            {
                MessageBox.Show("Dijite la identificacion.");
                return false;
            }
            else
            {
                if (ValidarNumero(txtIdentificacion.Text.Trim()) || txtIdentificacion.Text.Length < 7 || txtIdentificacion.Text.Length > 11)
                {
                    MessageBox.Show("Identificacion erronea.");
                    return false;
                }
                else
                {

                    if (txtNombre.Text.Trim()=="")
                    {
                        MessageBox.Show("Dijite el Nombre.");
                        return false;
                    }
                    else
                    {
                        if (txtCorreo.Text.Trim()=="")
                        {
                            MessageBox.Show("Dijite el correo.");
                            return false;
                        }
                        else
                        {

                            if (txtTelefono.Text.Trim()=="")
                            {
                                MessageBox.Show("Dijite el Telefono.");
                                return false;
                            }
                            else
                            {
                                if (ValidarNumero(txtTelefono.Text.Trim()))
                                {
                                    MessageBox.Show("Telefono erroneo.");
                                    return false;
                                }
                                else
                                {
                                    if (txtDireccion.Text.Trim() == "")
                                    {
                                        MessageBox.Show("Dijite el la direccion.");
                                        return false;
                                    }
                                    else
                                    {
                                        if (!ValidarCamposCuota())
                                        {
                                            return false;
                                        }
                                        else
                                        {
                                            if (TxtcantidadCuota.Text == "")
                                            {
                                                MessageBox.Show("Debe Calcular la cantidad de cuotas.");
                                                return false;
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }

                }
            }
            return true;

        }



        private bool ValidarCamposCuota() 
        {

            if (txtPrestamo.Text.Trim() == "")
            {
                MessageBox.Show("Dijite el valor del prestamo.");
                return false;
            }
            else
            {
                if (ValidarNumero(txtPrestamo.Text.Trim()))
                {
                    MessageBox.Show("Valor del prestamo erroneo.");
                    return false;
                }
                else
                {


                    if (Convert.ToDouble(txtPrestamo.Text.Trim()) < 100000 || Convert.ToDouble(txtPrestamo.Text.Trim()) > 3000000)
                    {
                        MessageBox.Show("No es posible prestar esa cantidad de dinero.");
                        return false;
                    }
                    else
                    {
                        if (carteraService.ValidarDineroRestante(Convert.ToDouble(txtPrestamo.Text.Trim())))
                        {
                            MessageBox.Show("No hay capital suficiente para prestar esa cantidad de dinero.");
                            return false;
                        }
                        else
                        {
                            if (txtValorcuota.Text.Trim() == "")
                            {
                                MessageBox.Show("Dijite el valor de cada cuota.");
                                return false;
                            }
                            else
                            {

                                if (ValidarNumero(txtValorcuota.Text.Trim()) || Convert.ToInt32(txtValorcuota.Text.Trim()) < 50 || Convert.ToInt32(txtValorcuota.Text.Trim()) > Convert.ToDouble(txtPrestamo.Text.Trim()))
                                {
                                    MessageBox.Show("Valor de las cuotas erroneo.");
                                    return false;
                                }
                            }
                        }
                    }

                }
            }
            return true;

        }


        private bool ValidarCorreo()
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)@\\w+([-.]\\w+)\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txtCorreo.Text.Trim(), expresion))
            {
                if (Regex.Replace(txtCorreo.Text.Trim(), expresion, String.Empty).Length == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
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

        private void btnCalcularcuotas_Click(object sender, EventArgs e)
        {
            CalcularCuotas();
        }

        private void limpiar() 
        {
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtPrestamo.Text = "";
            txtTelefono.Text = "";
            txtValorcuota.Text = "";
            TxtcantidadCuota.Text = "";
        }

        private bool ValidarCampos(int Campos)
        {
            return Campos switch{
                1 => ValidarCamposCuota(),
                2 => ValidarCampoPrestamo(),
                _ => false,
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrarPrestamo()
        {
            if (ValidarCampos(2))
            {
                Cliente cliente = new Cliente
                {
                    Identificacion = txtIdentificacion.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Estado = "Activo",
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim()
                    
                };
                Credito credito = new Credito
                {
                    IdCliente = cliente.Identificacion,
                    NumeroCuotas = Convert.ToInt32(CantidadCuotas),
                    Saldo = Convert.ToDouble(txtPrestamo.Text.Trim()) * 0.16 + Convert.ToDouble(txtPrestamo.Text.Trim()),
                    Cuota = Convert.ToDouble(txtValorcuota.Text.Trim())
                };
                credito.Interes = credito.Cuota * 0.16;
                carteraService.ActualizarCanttidadDeudores();
                carteraService.ActualizarDineroPrestado(Convert.ToDouble(txtPrestamo.Text.Trim()));

                MessageBox.Show(clienteService.Registrar(cliente, credito));
                limpiar();
            }
        }










    }
}
