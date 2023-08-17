using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzClubManagement
{
    class SportzClubManagementSystem
    {
        private List<Athelete> atheletes = new List<Athelete>();
        private List<Event> events = new List<Event>();
        private Dictionary<int,Dictionary<int,string>> performanceData = new Dictionary<int, Dictionary<int, string>>();

        public int RegisterAthlete(string firstName, string lastName, int age, string sport, DateTime registrationDate)
        {
            int atheleteId = atheletes.Count + 1;
            atheletes.Add(new Athelete(atheleteId, firstName, lastName, age, sport, registrationDate));
            return atheleteId;
        }

        public string ViewAtheleteDetails(int atheleId)
        {
            Athelete athelete = atheletes.FirstOrDefault(a => a.AtheleteId == atheleId);
            return atheleId != null ? $"Name : {athelete.FirstName} {athelete.LastName}, age : {athelete.Age}, Sport : {athelete.Sport}, Registration Date : {athelete.RegistrationDate}" : "Athlete Not Found";
        }

        public string UpdateAthleteDetails(int atheleteId, string firstName, string lastName, int age, string sport)
        {
            Athelete athelete = atheletes.FirstOrDefault(a => a.AtheleteId == atheleteId);
            if (athelete == null)
                return "Athelete Not Found";

            athelete.FirstName = firstName;
            athelete.LastName = lastName;
            athelete.Age = age;
            athelete.Sport = sport;

            return "Updated";

        }

        public string RemoveAthlete(int atheleId)
        {
            Athelete athelete = atheletes.FirstOrDefault(a => a.AtheleteId == atheleId);
            if (athelete == null)
                return "Athlete not Found";

            atheletes.Remove(athelete);
            return "Athelete removed";
        }

        public int CreateEvent(string eventName, string eventType, DateTime eventDate)
        {
            int eventId = events.Count + 1;
            events.Add(new Event(eventId, eventName, eventType, eventDate));
            return eventId;
        }

        public string ViewEventDetails(int eventId)
        {
            Event ev = events.FirstOrDefault(e => e.EventId == eventId);
            return ev != null ? $"Event Name: {ev.EventName}, Event Type: {ev.EventType}, Event Date: {ev.EventDate}" : "Event not found.";
        }

        public string UpdateEventDetails(int eventId, string eventName, string eventType, DateTime eventDate)
        {
            Event ev = events.FirstOrDefault(e => e.EventId == eventId);
            if (ev == null)
                return "Event not found.";

            ev.EventName = eventName;
            ev.EventType = eventType;
            ev.EventDate = eventDate;

            return "Update successful.";
        }

        public string RemoveEvent(int eventId)
        {
            Event ev = events.FirstOrDefault(e => e.EventId == eventId);
            if (ev == null)
                return "Event not found.";

            events.Remove(ev);
            return "Event removed successfully.";
        }

        public void RecordAthletePerformance(int athleteId, int eventId, string performanceData)
        {
            if (!this.performanceData.ContainsKey(athleteId))
                this.performanceData[athleteId] = new Dictionary<int, string>();

            this.performanceData[athleteId][eventId] = performanceData;
        }

        public string ViewAthletePerformance(int athleteId, int eventId)
        {
            if (this.performanceData.ContainsKey(athleteId) && this.performanceData[athleteId].ContainsKey(eventId))
                return this.performanceData[athleteId][eventId];

            return "Performance data not found.";
        }

        public List<Athlete> GetAthletesBySport(string sport)
        {
            return athletes.Where(a => a.Sport == sport).ToList();
        }

        public List<Event> GetEventsByType(string eventType)
        {
            return events.Where(e => e.EventType == eventType).ToList();
        }

        public Dictionary<string, string> GetAthletePerformanceInAllEvents(int athleteId)
        {
            Dictionary<string, string> performanceInAllEvents = new Dictionary<string, string>();

            if (performanceData.ContainsKey(athleteId))
            {
                foreach (var kvp in performanceData[athleteId])
                {
                    Event ev = events.FirstOrDefault(e => e.EventId == kvp.Key);
                    if (ev != null)
                    {
                        performanceInAllEvents[ev.EventName] = kvp.Value;
                    }
                }
            }

            return performanceInAllEvents;
        }

        public List<Event> GetUpcomingEvents()
        {
            DateTime currentDate = DateTime.Now;
            return events.Where(e => e.EventDate > currentDate).ToList();
        }
    }

}
