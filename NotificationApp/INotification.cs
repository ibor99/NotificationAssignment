using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApp
{
    public interface INotification
    {
        void SendNotification(string message);
    }
}
