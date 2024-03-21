using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApp
{
    public class NotificationService
    {
        private readonly List<INotification> _notificationTypes;

        public NotificationService(IEnumerable<INotification> notificationTypes)
        {
            _notificationTypes = notificationTypes.ToList();
        }

        public void SendNotification(string message) 
        {
            foreach ( var notType in _notificationTypes ) 
            {
                notType.SendNotification(message);
            }
        }
    }
}
