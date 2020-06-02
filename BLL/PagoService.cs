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

        private SqlConnection Conexion = null;

        public PagoService()
        {
            string strConexion = "Data Source=LAPTOP-GT43H27V\\SQLEXPRESS;Initial Catalog=payment; Integrated Security=True ";
            Conexion = new SqlConnection(strConexion);
            PagoRepository = new PagoRepository(Conexion);
        }
        public void RegistrarPago(Pago Pago)
        {
            Conexion.Open();
            Pago.IdPago = PagoRepository.ObtenerCodigo();
            PagoRepository.RegistrarPago(Pago);
            Conexion.Close();
        }
        public void GenerarExcel()
        {
            Exel excel = new Exel();
            excel.GenerarReportePagos(PagoRepository.Pagos);
        }
        public List<Pago> MostrarPagos()
        {
            Conexion.Open();
            List<Pago> pagos = PagoRepository.MostrarPagos();
            Conexion.Close();
            return pagos;
        }





    }
}
