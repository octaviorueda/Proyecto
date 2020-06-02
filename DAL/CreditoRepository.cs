using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ENTITY;

namespace DAL
{
   public  class CreditoRepository
    {
        private SqlConnection Conexion = null;
        private SqlCommand OrdenSql;
        private SqlDataReader Lector;
        public List<Credito> Creditos = new List<Credito>();
        public Credito Credito;

        public CreditoRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public void RegistrarCredito(Credito credito)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Insert into Credito (IdCredito, IdCliente, Saldo, Cuota, NumeroCuota, interes) values(@IdCredito, @IdCliente, @Saldo, @Cuota, @NumeroCuota, @Interes)";
                Comando.Parameters.Add("@IdCredito", System.Data.SqlDbType.VarChar).Value = credito.IdCredito;
                Comando.Parameters.Add("@Idcliente", System.Data.SqlDbType.VarChar).Value = credito.IdCliente;
                Comando.Parameters.Add("@Saldo", System.Data.SqlDbType.VarChar).Value = credito.Saldo;
                Comando.Parameters.Add("@Cuota", System.Data.SqlDbType.VarChar).Value = credito.Cuota;
                Comando.Parameters.Add("@NumeroCuota", System.Data.SqlDbType.Int).Value = credito.NumeroCuotas;
                Comando.Parameters.Add("@Interes", System.Data.SqlDbType.VarChar).Value = credito.Interes;
                Comando.ExecuteNonQuery();
            }
        }
        public Credito BuscarCredito(String IdentificacionClente)
        {
            MostrarCreditos();
            List<Credito> creditoEncontrados = Creditos.FindAll(creditoss => creditoss.IdCliente == IdentificacionClente);
            Credito = creditoEncontrados[0];
            return Credito;
        }
        public void ActualizarCredito(Credito credito)
        {
            ActualizarCreditoSql(credito);
        }
        private void ActualizarCreditoSql(Credito credito)
        {
            Conexion.Close();
            Conexion.Open();

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = $"update Credito set Saldo = {credito.Saldo}, Cuota = {credito.Cuota}, NumeroCuota = {credito.NumeroCuotas}where IdCredito = {credito.IdCredito}";
                Comando.ExecuteNonQuery();
            }
        }
        public List<Credito> MostrarCreditos()
        {
            Conexion.Close();
            Conexion.Open();
            string Consulta = "Select * from Credito";
            OrdenSql = new SqlCommand(Consulta, Conexion);
            Lector = OrdenSql.ExecuteReader();
            while (Lector.Read())
            {
                Credito = new Credito
                {
                    IdCliente = Lector["IdCliente"].ToString(),
                    IdCredito = Lector["IdCredito"].ToString(),
                    Saldo = Convert.ToDouble(Lector["Saldo"]),
                    Cuota = Convert.ToDouble(Lector["Cuota"]),
                    NumeroCuotas = Convert.ToInt32(Lector["NumeroCuota"]),
                    Interes = Convert.ToDouble(Lector["Interes"])
                };
                Creditos.Add(Credito);
            }
            return Creditos;
        }

        public string ObtenerCodigo()
        {
            string codigo;
            string Consulta = "select codigoCredito from Codigos";
            OrdenSql = new SqlCommand(Consulta, Conexion);
            Lector = OrdenSql.ExecuteReader();
            Lector.Read();
            codigo = Convert.ToString(Lector["codigoCredito"]);
            ActualizarCodigo(codigo);
            return codigo;
        }

        public void ActualizarCodigo(string codigo)
        {
            Conexion.Close();
            Conexion.Open();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = $"update Codigos  set codigoCredito = {Convert.ToInt32(codigo)}+1";
                Comando.ExecuteNonQuery();

            }
        }

    }
}
