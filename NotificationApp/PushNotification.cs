using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApp
{
    public class PushNotification : INotification
    {
        public void SendNotification(User user, string message)
        {
            Console.WriteLine($"Sending Push notification to {user.Email} : {message}");
        }
    }
}
