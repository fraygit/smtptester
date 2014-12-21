using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace smtpmailer
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage message = new MailMessage("info@filgifts.com", "paz.astadan@gmail.com");
            message.Subject = "smtp using .net";
            message.Body = "how cool is this!";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "email-smtp.us-west-2.amazonaws.com";
            smtp.Credentials = new NetworkCredential("yourUsername", "yourPassword");
            smtp.EnableSsl = true;
            smtp.Send(message);
        }
    }
}
