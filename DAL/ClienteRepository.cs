using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DAL
{
    public class ClienteRepository
    {
        SqlConnection Connection;
        private SqlCommand Ordensql;
        private SqlDataReader lector;
        public List<Cliente> Clientes = new List<Cliente>();
        public Cliente cliente;


        public ClienteRepository(ConnectionManager connection)
        {
            Connection = connection.Connection;
        }
        public List<Cliente> MostrarCliente()
        {
            Connection.Close();
            Connection.Open();
            string Consulta = "select * from Cliente ";
            Ordensql = new SqlCommand(Consulta, Connection);
            lector = Ordensql.ExecuteReader();
            while (lector.Read())
            {
                cliente = new Cliente
                {
                    Identificacion = lector["Identificacion"].ToString(),
                    Nombre = lector["Nombre"].ToString(),
                    Correo = lector["Identificacion"].ToString(),
                    Direccion = lector["Nombre"].ToString(),
                    Estado = lector["Estado"].ToString(),
                    Telefono = lector["Nombre"].ToString()
                };
                Clientes.Add(cliente);
            }
            return Clientes;
           
        }

        public void ActualizarEstado(string identificacion)
        {
            MostrarCliente();
            List<Cliente> EstadoCliente = Clientes.FindAll(cliente => cliente.Identificacion == identificacion);
            EstadoCliente[0].Estado = "Inactivo";
            ActualizarCliente("Estado", EstadoCliente[0].Estado, EstadoCliente[0].Identificacion);

        }

        public void ActualizarCliente(string campo, string valor, string identificacion)
        {
            Connection.Close();
            Connection.Open();
            using (var comando = Connection.CreateCommand())
            {
                comando.CommandText = $"update Cliente set {campo}= '{valor}' where Identificacion ={identificacion}";
                comando.ExecuteNonQuery();
            }
        }

        public bool BuscarExisteCliente(string identificacion)
        {
            MostrarCliente();
            List<Cliente> ExisteCliente = Clientes.FindAll(cliente => cliente.Identificacion == identificacion);
            if (ExisteCliente.Count() == 0)
            {
                return false;
            }
            return true;
        }
        public bool BuscarInformacion(string identificacion)
        {
            MostrarCliente();
            List<Cliente> ExisteCliente = Clientes.FindAll(cliente => cliente.Identificacion == identificacion);
            if (ExisteCliente.Count() == 0)
            {
                return false;
            }
            cliente = ExisteCliente[0];
            return true;
        }

        public bool BuscarEstadoCliente(string identificacion)
        {
            MostrarCliente();
            List<Cliente> EstadoCliente = Clientes.FindAll(cliente => cliente.Identificacion == identificacion && cliente.Estado == "Inactivo");
            if (EstadoCliente.Count == 0)
            {
                return false;
            }
            ActualizarCliente("Estado", "Activo", EstadoCliente[0].Identificacion);
            return true;
        }



        public void RegistarCliente(Cliente cliente) 
        {
            Connection.Close();
            Connection.Open();
            using (var comando = Connection.CreateCommand())
            {
                comando.CommandText = "Insert into Cliente (Nombre, Direccion, Correo, Telefono, Identificacion) values(@Nombre, @Direccion, @Correo, @Telefono, @Identificacion)";
                comando.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar).Value = cliente.Nombre;
                comando.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar).Value = cliente.Direccion;
                comando.Parameters.Add("@Correo", System.Data.SqlDbType.VarChar).Value = cliente.Correo;
                comando.Parameters.Add("@Telefono", System.Data.SqlDbType.VarChar).Value = cliente.Telefono;
                comando.Parameters.Add("@Identificacion", System.Data.SqlDbType.VarChar).Value = cliente.Identificacion;
                comando.ExecuteNonQuery();
            }
            Connection.Close();        
        }






    }
}
