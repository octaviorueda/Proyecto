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
   public  class CarteraService
    {
        private SqlConnection Conexion = null;
        CarteraRepository CarteraRepository;
        public Cartera Cartera;
        public CarteraService()
        {
            string strConexion = "Data Source=LAPTOP-GT43H27V\\SQLEXPRESS;Initial Catalog=payment; Integrated Security=True ";
            Conexion = new SqlConnection(strConexion);
            CarteraRepository = new CarteraRepository(Conexion);
        }
        public void ActualizarCanttidadDeudoresMenos()
        {
            Conexion.Open();
            CarteraRepository.ActualizarCantidadDeudoresMenos();
            Conexion.Close();
        }
        public void ActualizarCanttidadDeudores()
        {
            Conexion.Open();
            CarteraRepository.ActualizarCantidadDeudores();
            Conexion.Close();
        }
        public void ActualizarDineroPrestado(double CantidadPrestado)
        {
            Conexion.Open();
            CarteraRepository.ActualizarDineroPrestado(CantidadPrestado);
            Conexion.Close();
        }

        public void ActualizarDineroRestante(double CantidadAbono)
        {
            Conexion.Open();
            CarteraRepository.ActualizarDineroRestante(CantidadAbono);
            Conexion.Close();
        }

        public bool ValidarDineroRestante(double CantidadPrestamo)
        {
            bool SiNo;
            Conexion.Open();
            SiNo = CarteraRepository.ValidarDineroRestante(CantidadPrestamo);
            Conexion.Close();
            return SiNo;
        }
        public Cartera MostrarCartera()
        {
            Conexion.Open();
            Cartera = CarteraRepository.MostrarCartera();
            Conexion.Close();
            return Cartera;
        }







    }
}
