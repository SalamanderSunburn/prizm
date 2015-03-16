﻿using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Forms.Notifications.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers
{
    class NotRequiredCache : IEnumerable<Guid>
    { 
        private struct NotRequiredCachePack
        {
            int frequency;
            FrequencyMeasure measure;
            float unitsLeft;
            string operationCode;
            string operationName;
            string pipeSizeTypeName;
        }
        private Dictionary<Guid, NotRequiredCachePack> internalCache = new Dictionary<Guid, NotRequiredCachePack>();

        public void AddOrReplace(
            Guid notRequiredOperationId, 
            int Frequency, float unitsLeft, 
            string operationCode, string operationName, string pipeSizeTypeName,
            FrequencyMeasure measure)
        {
            internalCache[notRequiredOperationId] = 
                new NotRequiredCachePack() 
                {
                    // TODO: init all struct members from arguments
                };
        }

        public void Clear()
        {
            internalCache.Clear();
        }

        public void SetUnitsLeft(Guid pipeTestId, float unitsProducedSinceLastDate)
        { 
            // TODO
        }

        public bool IsGoingToExpire(Guid pipeTestId)
        { 
            // TODO (is after 90%)
            return false;
        }

        public IEnumerator<Guid> GetEnumerator()
        {
            return internalCache.Keys.AsEnumerable<Guid>().GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class NotRequiredOperationManager : NotificationManager,  INotRequiredOperationManager
    {
        private NotRequiredCache cache = new NotRequiredCache();

        public NotRequiredOperationManager()
            : base(null)
        {
        }

        public override TypeNotification Type { get { return TypeNotification.NotRequiredInspectionOperation; } }

        public static Notification CreateNotification(Guid userId, string ownerName, float unitsLeft, string information)
        {
            return new Notification(userId, ownerName, TypeNotification.NotRequiredInspectionOperation, information, unitsLeft);
        }


        public void RefreshNotification(Guid operationId, float unitsToAdd)
        {
            
        }

        /// <summary>
        /// This method should be used when "Passed" NRO at pipe was removed or set to other not ready state, or pipe was deactivated.
        /// </summary>
        /// <param name="operationId"></param>
        private void LoadNotifications(Guid operationId)
        { 
            // TODO: reload certain NRO data to cache 
        }

        public override void LoadNotifications()
        {
            base.LoadNotifications();

            // TODO: renew cache and notifications list

            /*
             * 0) Clear the cache
             * 1) DB sql request: Read size types + not required inspection operations, from settings. Use internalCache.Add to add all information (except for unitsLeft)
             *      (INPUT: none)
             *      (OUTPUT: pipe size type name (!), pipe test id, operation code, operation name, frequency, frequency measure)
             * 2) DB sql request: Read all MAX dates including NULL, ordering by not required inspection operations, in pipe test results. 
             *      (INPUT: none)
             *      (OUTPUT: pipe test id, date (can be NULL))
             * 3) DB sql request: Read all "unitsProducedSinceLastDate" for all not required inspection operations.
             *      (INPUT: pipe test id, MAX date, frequency measure)
             *      (OUTPUT: pipe test id, unitsProducedSinceLastDate)
             * 4) modify for each cache entry: unitsLeft = frequency - unitsProducedSinceLastDate (use SetUnitsLeft)
             * 
             * 5) iterate cache and use IsGoingToExpire to determine whether to create Notification (use this.CreateNotification)
             * 
             */
        }

        public void NotRequiredOperationWasRemoved(Guid operationId)
        {
            LoadNotifications(operationId);
        }
    }
}
