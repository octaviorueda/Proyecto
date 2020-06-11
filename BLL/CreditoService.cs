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
        private ConnectionManager connection;

        public CreditoService(string connetionstring)
        {
            connection = new ConnectionManager(connetionstring);
            CreditoRepository = new CreditoRepository(connection);
        }

        public void Registrar(Credito credito)
        {
            connection.Open();
            credito.IdCredito = CreditoRepository.ObtenerCodigo();
            CreditoRepository.RegistrarCredito(credito);
            connection.Closed();
        }

        public Credito BuscarCedito(String IdentifiacionCliente)
        {
            connection.Open();
            CreditoRepository.BuscarCredito(IdentifiacionCliente);
            connection.Closed();
            return CreditoRepository.Credito;
        }
        public void ActualizarCredito(Credito credito)
        {
            connection.Open();
            CreditoRepository.ActualizarCredito(credito);
            connection.Closed();
        }
        public void GenerarExcel()
        {
            Exel excel = new Exel();
            excel.GenerarReporteCreditos(CreditoRepository.Creditos);
        }
        public List<Credito> MostrarCredito()
        {
            connection.Open();
            Creditos = CreditoRepository.MostrarCreditos();
            connection.Closed();
            return Creditos;
        }


















    }
}
