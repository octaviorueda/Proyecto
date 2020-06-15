using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.Data.SqlClient;
using DAL;
using Infraestructura;


namespace BLL
{
    public class CreditoService
    {

        public Credito Credito;
        CreditoRepository CreditoRepository;
        List<Credito> Creditos;
        List<Pago> pagos = new List<Pago>() ;
        public Pago pago;
        private ConnectionManager connection;

        public CreditoService(string connetionstring)
        {
            connection = new ConnectionManager(connetionstring);
            CreditoRepository = new CreditoRepository(connection);
        }

        public void Registrar(Credito credito)
        {
            try
            {
                connection.Open();
                credito.IdCredito = CreditoRepository.ObtenerCodigo();
                CreditoRepository.RegistrarCredito(credito);
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

        public List<Pago> mostarpagosclientes(string id)
        {
            try
            {
                connection.Open();
                pagos = CreditoRepository.MostarPagosCliente(id);
                return pagos;
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

        public Credito BuscarCedito(String IdentifiacionCliente)
        {
            try
            {
                connection.Open();
                CreditoRepository.BuscarCredito(IdentifiacionCliente);
                return CreditoRepository.Credito;
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
        public void ActualizarCredito(Credito credito)
        {
            try
            {
                connection.Open();
                CreditoRepository.ActualizarCredito(credito);

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
        public void GenerarExcel()
        {
            Exel excel = new Exel();
            excel.GenerarReporteCreditos(CreditoRepository.Creditos);
        }
        public List<Credito> MostrarCredito()
        {
            try
            {
                connection.Open();
                Creditos = CreditoRepository.MostrarCreditos();
                
                return Creditos;

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
