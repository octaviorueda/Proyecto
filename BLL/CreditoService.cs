﻿using System;
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
        private SqlConnection Conexion = null;
        public Credito Credito;
        CreditoRepository CreditoRepository;
        List<Credito> Creditos;

        public CreditoService()
        {
            string strConexion = "Data Source=LAPTOP-GT43H27V\\SQLEXPRESS;Initial Catalog=payment; Integrated Security=True ";
            Conexion = new SqlConnection(strConexion);
            CreditoRepository = new CreditoRepository(Conexion);
        }

        public void Registrar(Credito credito)
        {
            Conexion.Open();
            credito.IdCredito = CreditoRepository.ObtenerCodigo();
            CreditoRepository.RegistrarCredito(credito);
            Conexion.Close();
        }

        public Credito BuscarCedito(String IdentifiacionCliente)
        {
            Conexion.Open();
            CreditoRepository.BuscarCredito(IdentifiacionCliente);
            Conexion.Close();
            return CreditoRepository.Credito;
        }
        public void ActualizarCredito(Credito credito)
        {
            Conexion.Open();
            CreditoRepository.ActualizarCredito(credito);
            Conexion.Close();
        }
        public void GenerarExcel()
        {
            Exel excel = new Exel();
            excel.GenerarReporteCreditos(CreditoRepository.Creditos);
        }
        public List<Credito> MostrarCredito()
        {
            Conexion.Open();
            Creditos = CreditoRepository.MostrarCreditos();
            Conexion.Close();
            return Creditos;
        }


















    }
}
