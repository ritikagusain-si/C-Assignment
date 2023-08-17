using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzClubManagement
{
    class Event
    {
        public int EventId { get; }

        public string EventName { get; }

        public string EventType { get; }

        public DateTime EventDate { get; }

        public Event(int eventId, string eventName, string eventType, DateTime eventDate)
        {
            EventId = eventId;
            EventName = eventName;
            EventType = eventType;
            EventDate = eventDate;
        }
    }
}
