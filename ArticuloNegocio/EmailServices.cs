using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloNegocio
{
       public class EmailServices
    {
        
        
            private MailMessage email;
            private SmtpClient server;
            public EmailServices()
            {
                server = new SmtpClient();
                server.Credentials = new NetworkCredential("5ec9158c2ef7cb", "********6c7c");
                server.EnableSsl = true;
                server.Port = 2525;
                server.Host = "sandbox.smtp.mailtrap.io";
            }
            public void armarCorreo(string emailDestino, string asunto, string mensaje)
            {
                email = new MailMessage();
                email.From = new MailAddress("noresponder@articulos-web.com");
                email.To.Add(emailDestino);
                email.Subject = asunto;
                email.IsBodyHtml = true;
                email.Body = mensaje;
            }
            public void enviarEmail()
            {
                try
                {
                    server.Send(email);
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        
    }
}
