namespace SportzClubManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SportzClubManagementSystem system = new SportzClubManagementSystem();

            int athleteId1 = system.RegisterAthlete("Ritika", "Gusain", 23, "TableTennis", DateTime.Now);
            int athleteId2 = system.RegisterAthlete("Shubham", "Payal", 25, "Football", DateTime.Now);
            int athleteId3 = system.RegisterAthlete("Annu", "Payal", 30, "Badminton", DateTime.Now);

            int eventId1 = system.CreateEvent("TableTennis Tournament", "Tournament", DateTime.Now.AddDays(7));
            int eventId2 = system.CreateEvent("Football Practice", "Practice", DateTime.Now.AddDays(3));
            int eventId3 = system.CreateEvent("Badminton Exhibition", "Exhibition", DateTime.Now.AddDays(10));

            system.RecordAthletePerformance(athleteId1, eventId1, "Score: 90");
            system.RecordAthletePerformance(athleteId2, eventId2, "Time: 45 minutes");
            system.RecordAthletePerformance(athleteId3, eventId3, "Goals: 2");


            Console.WriteLine(system.ViewAthleteDetails(athleteId1));
            Console.WriteLine(system.ViewEventDetails(eventId1));
            Console.WriteLine(system.ViewAthletePerformance(athleteId1, eventId1));

            Console.WriteLine("\n---------------Athletes in Basketball-------------------:");
            List<Athlete> basketballAthletes = system.GetAthletesBySport("Basketball");
            foreach (Athlete athlete in basketballAthletes)
            {
                Console.WriteLine($"{athlete.FirstName} {athlete.LastName}");
            }

            Console.WriteLine("\n---------------Upcoming events: ----------------------------");
            List<Event> upcomingEvents = system.GetUpcomingEvents();
            foreach (Event ev in upcomingEvents)
            {
                Console.WriteLine($"Event Name: {ev.EventName}, Date: {ev.EventDate}");
            }
    }
}