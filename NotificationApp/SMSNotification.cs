using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApp
{
    public class SMSNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS notification : {message}");
        }
    }
}
