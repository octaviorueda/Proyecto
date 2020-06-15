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
    public partial class FrmCartera : Form
    {
        Cartera Cartera;
        List<Credito> Creditos;
        List<Pago> pagos ;
        List<Cliente> Clientes;
        CarteraService carteraService;
        ClienteService clienteService = new ClienteService(ConfigConnection.connectionString);
        CreditoService creditoService;
        PagoService pagoService;

        public FrmCartera()
        {
            InitializeComponent();
            inizializar();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void inizializar()
        {
            carteraService = new CarteraService(ConfigConnection.connectionString);
            creditoService = new CreditoService(ConfigConnection.connectionString);
            pagoService = new PagoService(ConfigConnection.connectionString);
            Cartera = carteraService.MostrarCartera();
            //pagos = pagoService.MostrarPagos();
            //Clientes = clienteService.MostrarClientes();
            //Creditos = creditoService.MostrarCredito();

            pagos = carteraService.CargarPagos();
            Clientes = carteraService.CargarClientes();
            Creditos = carteraService.CargarCredito();
            PintarCartera();
            PintarTablas();




        }

        private void PintarCartera()
        {
            txtDeudores.Text = Cartera.CantidadDeudores.ToString();
            txtCapital.Text = Cartera.Capital.ToString();
            txtDinerodisponible.Text = Cartera.DineroRestante.ToString();
            txtDineroprestado.Text = Cartera.DineroPrestado.ToString();
        }

        private void PintarTablas()
        {
            DataClientes.DataSource = Clientes;
            DataCartera.DataSource = Creditos;
            DataIngresos.DataSource = pagos;
        }


        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            clienteService.GenerarExcel();
            creditoService.GenerarExcel();
            pagoService.GenerarExcel();
            MessageBox.Show("Reportes Generados correctamente.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void DataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataCartera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
