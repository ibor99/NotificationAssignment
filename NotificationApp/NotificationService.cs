using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApp
{
    public class NotificationService
    {
        private readonly List<INotification> _notificationWays;

        public NotificationService(IEnumerable<INotification> notificationTypes)
        {
            _notificationWays = notificationTypes.ToList();
        }

        public void SendNotification(User user, string message) 
        {
            foreach ( var notificationWay in _notificationWays ) 
            {
                notificationWay.SendNotification(user,message);
            }
        }
    }
}
