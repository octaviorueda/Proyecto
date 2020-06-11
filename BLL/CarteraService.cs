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
       
        CarteraRepository CarteraRepository;
        public Cartera Cartera;
        private ConnectionManager connection;
        public CarteraService(string connectionstring)
        {

            connection = new ConnectionManager(connectionstring);
            CarteraRepository = new CarteraRepository(connection);
        }
        public void ActualizarCanttidadDeudoresMenos()
        {
            connection.Open();
            CarteraRepository.ActualizarCantidadDeudoresMenos();
            connection.Closed();
        }
        public void ActualizarCanttidadDeudores()
        {
            connection.Open();
            CarteraRepository.ActualizarCantidadDeudores();
            connection.Closed();
        }
        public void ActualizarDineroPrestado(double CantidadPrestado)
        {
            connection.Open();
            CarteraRepository.ActualizarDineroPrestado(CantidadPrestado);
            connection.Closed();
        }

        public void ActualizarDineroRestante(double CantidadAbono)
        {
            connection.Open();
            CarteraRepository.ActualizarDineroRestante(CantidadAbono);
            connection.Closed();
        }

        public bool ValidarDineroRestante(double CantidadPrestamo)
        {
            bool SiNo;
            connection.Open();
            SiNo = CarteraRepository.ValidarDineroRestante(CantidadPrestamo);
            connection.Closed();
            return SiNo;
        }
        public Cartera MostrarCartera()
        {
            connection.Open();
            Cartera = CarteraRepository.MostrarCartera();
            connection.Closed();
            return Cartera;
        }







    }
}
