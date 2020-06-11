using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.Data.SqlClient;

namespace DAL
{
   public class CarteraRepository
    {
        private SqlConnection Conexion;
        private SqlCommand OrdenSql;
        private SqlDataReader Lector;
        public Cartera cartera = new Cartera();

        public CarteraRepository(ConnectionManager connection)
        {
            Conexion = connection.Connection;
        }

        public void ActualizarDineroPrestado(double CantidadPrestado)
        {
            MostrarCartera();
            cartera.DineroPrestado += CantidadPrestado;
            ActualizarCartera("DineroPrestado",cartera.DineroPrestado.ToString());
            cartera.DineroRestante -= CantidadPrestado;
            ActualizarCartera("DineroRestante",cartera.DineroRestante.ToString());
        }


        public void ActualizarDineroRestante(Double CantidadAbono) 
        {
            MostrarCartera();
            cartera.DineroPrestado -= CantidadAbono;
            if (cartera.DineroPrestado < 0)
            {
                cartera.DineroPrestado = 0;
            }
            ActualizarCartera("DineroPrestado", cartera.DineroPrestado.ToString());
            cartera.DineroRestante += CantidadAbono;
            if (cartera.DineroRestante > 30000000)
            {
                cartera.DineroRestante = 30000000;
            }
            ActualizarCartera("DineroRestante", cartera.DineroRestante.ToString());
        }

        public void ActualizarCantidadDeudoresMenos() 
        {
            MostrarCartera();
            cartera.CantidadDeudores--;
            ActualizarCartera("CantidadDeudores",cartera.CantidadDeudores.ToString());
        }
        public void ActualizarCantidadDeudores() 
        {
            MostrarCartera();
            cartera.CantidadDeudores++;
            ActualizarCartera("CantidadDeudores", cartera.CantidadDeudores.ToString());
        }
        public bool ValidarDineroRestante(Double cantidadPrestamo) 
        {
            MostrarCartera();
            if (cartera.DineroRestante-cantidadPrestamo< 50)
            {
                return true;
            }
            return false;
        }
        public Cartera MostrarCartera() 
        {
            Conexion.Close();
            Conexion.Open();
            string Consulta = "Select * from Cartera";
            OrdenSql = new SqlCommand(Consulta, Conexion);
            Lector = OrdenSql.ExecuteReader();
            Lector.Read();
            cartera.CantidadDeudores = Convert.ToInt32(Lector["CantidadDeudores"]);
            cartera.Capital = Convert.ToDouble(Lector["Capital"]);
            cartera.DineroPrestado = Convert.ToDouble(Lector["DineroPrestado"]);
            cartera.DineroRestante = Convert.ToDouble(Lector["DineroRestante"]);
            return cartera;
        }
        public void ActualizarCartera(string Campo, string valor) 
        {
            Conexion.Close();
            Conexion.Open();
            using (var Comando= Conexion.CreateCommand()) 
            {
                Comando.CommandText = $"update Cartera set {Campo} = {valor}";
                Comando.ExecuteNonQuery();
            }


        }


    }
}
