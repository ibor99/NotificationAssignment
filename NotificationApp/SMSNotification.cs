using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApp
{
    public class SMSNotification : INotification
    {
        public void SendNotification(User user, string message)
        {
            Console.WriteLine($"Sending SMS notification to {user.Email} : {message}");
        }
    }
}
