using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;
using Infraestructura;
using System.Data.SqlClient;

namespace BLL
{
    public class ClienteService
    {
       
        public Cliente cliente;
        public List<Cliente> Clientes;
        ClienteRepository ClienteRepository;
        CreditoService creditoService;
        private ConnectionManager connection;
        

        public ClienteService(string connectionString)
        {
            
            connection = new ConnectionManager(connectionString);
            ClienteRepository = new ClienteRepository(connection);
            creditoService = new CreditoService();

        }

        public List<Cliente> MostrarClientes()
        {
            connection.Open();
            Clientes = ClienteRepository.MostrarCliente();
            connection.Closed();
            return Clientes;
        }
        public void ActualizarEstado(String Identificacion)
        {
            connection.Open();
            ClienteRepository.ActualizarEstado(Identificacion);
            connection.Closed();
        }
        public String Registrar(Cliente cliente, Credito credito)
        {
            Correo correo = new Correo();
            String mensajeCorreo;
            connection.Open();
            if (ClienteRepository.BuscarExisteCliente(cliente.Identificacion))
            {
                if (ClienteRepository.BuscarEstadoCliente(cliente.Identificacion))
                {
                    creditoService.Registrar(credito);
                    mensajeCorreo = correo.EnviarEmail(cliente);
                    connection.Closed();
                    return $"Ya Existe un cliente registrado con esta identificacion pero su estado es Inactivo. Se volvio activo y se le hizo el prestamo. {mensajeCorreo}";
                }
                else
                {
                    connection.Closed();
                    return "Ya existe un cliente con esta identificacion pero su estado es activo, asi que no se puede hacer el prestamo.";
                }
            }
            mensajeCorreo = correo.EnviarEmail(cliente);
            ClienteRepository.RegistarCliente(cliente);
            creditoService.Registrar(credito);
            connection.Closed();
            return $"Registrado correctamente. {mensajeCorreo}";
        }

        public bool BuscarInformacion(String Identificacion)
        {
            connection.Open();
            if (ClienteRepository.BuscarInformacion(Identificacion))
            {
                connection.Closed();
                return true;
            }
            connection.Closed();
            return false;
        }

        public void GenerarExcel()
        {
            Exel excel = new Exel();
            excel.GenerarReporteClientes(ClienteRepository.Clientes);
        }
        public Cliente InformacionCliente()
        {
            return ClienteRepository.cliente;
        }





    }
}
