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
   public class PagoService
    {
        PagoRepository PagoRepository;
        private ConnectionManager connection;
        

        public PagoService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
           
            PagoRepository = new PagoRepository(connection);
        }
        public void RegistrarPago(Pago Pago)
        {
            connection.Open();
            Pago.IdPago = PagoRepository.ObtenerCodigo();
            PagoRepository.RegistrarPago(Pago);
            connection.Closed();
        }
        public void GenerarExcel()
        {
            Exel excel = new Exel();
            excel.GenerarReportePagos(PagoRepository.Pagos);
        }
        public List<Pago> MostrarPagos()
        {
            connection.Open();
            List<Pago> pagos = PagoRepository.MostrarPagos();
            connection.Closed();
            return pagos;
        }





    }
}
