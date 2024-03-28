using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApp
{
    public class EmailNotification : INotification
    {
        public void SendNotification(User user, string message)
        {
            Console.WriteLine($"Sending email notification to {user.Email} :  {message}");

            string senderEmail = "badearo99@gmail.com";
            string password = "ytxz ykyy uhsx zlyp";

            using MailMessage mail = new MailMessage(senderEmail, user.Email);
            mail.Subject = "App Notification";
            mail.Body = message;

            using SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new NetworkCredential(senderEmail, password);
            client.EnableSsl = true;

            try
            {
                client.Send(mail);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Failed to send email : {ex.Message}");
            }
        }
    }
}
