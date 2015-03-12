﻿using Prizm.Main.Forms.Notifications.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers
{
    class NotRequiredControlOperationPipesManager : NotificationManager, INotRequiredControlOperationPipesManager
    {
        public NotRequiredControlOperationPipesManager()
            : base(new NotRequiredControlOperationPipesLoader())
        { 
        }

        public override TypeNotification Type { get { return TypeNotification.NotRequiredControlOperationPipes; } }

        public static Notification CreateNotification(Guid userId, string ownerName, float timeToOccur, string information)
        {
            Notification n = new Notification(userId, ownerName, TypeNotification.NotRequiredControlOperationPipes, timeToOccur, information);
            if (n.TimeToOccur > 0)
            {
                n.Status = NotificationStatus.Warning;
            }
            else
            {
                n.Status = NotificationStatus.Critical;
            }
            return n;
        }

        public void RefreshNotification(Guid pipe, string oldNumber, string newNumber)
        {
            throw new NotImplementedException();
        }
    }
}

