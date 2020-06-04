using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using ENTITY;

namespace Infraestructura
{
    public class Correo
    {
       public  string ruta = @"C:\Reportes PAYMENTF";
        private MailMessage email;
        private SmtpClient smtp;
        Exel exel;
        public Correo()
        {
            smtp = new SmtpClient();
            exel = new Exel();
        }
        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("Paymenttofeets@gmail.com",
            "Pa123456");
        }
        private void ConfigurarEmail(Cliente cliente)
        {
            email = new MailMessage();
            email.To.Add(cliente.Correo);
            email.From = new MailAddress("Paymenttofeets@gmail.com");
            email.Subject = $"Registro Exitoso";
            email.Body = $"<b>Sr {cliente.Nombre }</b> <br " +
            $" > se ha realizado su registro Sartisfactoriamente";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }
        private void ConfigurarEmailExel(string correo)
        {
            email = new MailMessage();
            email.To.Add(correo);
            email.From = new MailAddress("Paymenttofeets@gmail.com");
            email.Subject = $"Registro Exitoso";
            email.Body = $"<b>Sr {correo }</b> <br " +
            $" > el reporte de los clientes se ecuentra adjunto en este archivo";
            email.Attachments.Add(new Attachment(ruta));
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }
        public string EnviarEmail(Cliente cliente)
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmail(cliente);
                smtp.Send(email);
                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {
                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }

        }


        public string EnviarEmailExel(string correo)
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmailExel(correo);
                smtp.Send(email);
                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {
                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }

        }




    }
}
