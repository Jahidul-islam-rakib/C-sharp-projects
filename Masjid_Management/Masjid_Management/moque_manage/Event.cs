using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masjid_Management.moque_manage
{
    public class Event
    {
        public int eventId;
        public string eventName;
        public string eventDate;
        public string eventPlace;

        public Event(int EventId, string EventName, string EventDate, string EventPlace)
        {
            eventId = EventId;
            eventName = EventName;
            eventDate = EventDate;
            eventPlace = EventPlace;
        }

    }
}
