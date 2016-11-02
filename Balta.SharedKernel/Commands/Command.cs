using Balta.SharedKernel.Notifications;
using System.Collections.Generic;

namespace Balta.SharedKernel.Commands
{
    public class Command
    {
        public List<DomainNotification> Notifications { get; set; }

        public Command()
        {
            Notifications = new List<DomainNotification>();
        }
    }
}
