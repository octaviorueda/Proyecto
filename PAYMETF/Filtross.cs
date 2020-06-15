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
using ENTITY;

namespace PAYMETF
{
    public partial class Filtross : Form
    {
        Cliente cliente;
        CarteraService carteraService;
        CreditoService creditoService;
        ClienteService clienteService;
        List<Cliente> clientes;
        List<Pago> pagos;
        List<Credito> creditos;
        public Filtross()
        {
            InitializeComponent();
            inicializar();
        }
        private void inicializar() 
        {
            cliente = new Cliente();
            creditoService = new CreditoService(ConfigConnection.connectionString);
            carteraService = new CarteraService(ConfigConnection.connectionString);
            clienteService = new ClienteService(ConfigConnection.connectionString);

            clientes = carteraService.CargarClientes();
            Pintartabla();
        }


        

        private void Pintartabla() 
        {
            datostodos.DataSource = clientes;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void datostodos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

         private void cargarClientes() 
        {
            string estado;
            clientes.Clear();
            if (cmbestado.SelectedIndex == 0)
            {
                datostodos.DataSource = null;
                datostodos.Refresh();
                
                estado = "Activo";
                clientes = clienteService.MostrarEstado(estado);
                datostodos.DataSource = clientes;
                

            }
            else if (cmbestado.SelectedIndex== 1)
            {
                datostodos.DataSource = null;
                estado = "Inactivo";
                clientes = clienteService.MostrarEstado(estado);
                datostodos.DataSource = clientes;
                datostodos.Refresh();


            }
            else if (cmbestado.SelectedIndex == 2)
            {
                clientes = carteraService.CargarClientes();
                datostodos.DataSource = clientes;
                datostodos.Refresh();
            }


           
        }




        private void btncargarclietes_Click(object sender, EventArgs e)
        {
            cargarClientes();

        }

        private void datostodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombre.Text = datostodos.CurrentRow.Cells[0].Value.ToString();
            txtidentificcion.Text =datostodos.CurrentRow.Cells[4].Value.ToString();
        }

        private void btncargarinfo_Click(object sender, EventArgs e)
        {
            string id;
            if (cmbinformacion.SelectedIndex == 0)
            {
                id = txtidentificcion.Text;
                pagos = creditoService.mostarpagosclientes(id);
                datafiltros.DataSource = pagos;
            }
            
        }
    }
}
