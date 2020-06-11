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
            try
            {

                connection.Open();
                CarteraRepository.ActualizarCantidadDeudoresMenos();
                

            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                connection.Closed();
            }
        }
        public void ActualizarCanttidadDeudores()
        {
            try
            {
                connection.Open();
                CarteraRepository.ActualizarCantidadDeudores();
                

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Closed();
            }
           
        }
        public void ActualizarDineroPrestado(double CantidadPrestado)
        {
            try
            {

                connection.Open();
                CarteraRepository.ActualizarDineroPrestado(CantidadPrestado);
                

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Closed();
            }
        }

        public void ActualizarDineroRestante(double CantidadAbono)
        {
            try
            {
                connection.Open();
                CarteraRepository.ActualizarDineroRestante(CantidadAbono);
                

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Closed();
            }
           
        }

        public bool ValidarDineroRestante(double CantidadPrestamo)
        {
            try
            {
                bool SiNo;
                connection.Open();
                SiNo = CarteraRepository.ValidarDineroRestante(CantidadPrestamo);
                
                return SiNo;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Closed();
            }
            
        }
        public Cartera MostrarCartera()
        {
            try
            {

                connection.Open();
                Cartera = CarteraRepository.MostrarCartera();
                
                return Cartera;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Closed();
            }
        }







    }
}
