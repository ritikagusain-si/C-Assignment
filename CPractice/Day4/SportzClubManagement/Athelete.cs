using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzClubManagement
{
    class Athelete
    {
        public int AtheleteId { get; }
        public string FirstName { get; }

        public string LastName { get; }

        public int Age { get; }

        public string Sport { get; }

        public DateTime RegistrationDate { get; }


        public Athelete(int atheleteId, string firstName, string lastName, int age, string sport, DateTime registrationDate)
        {
            AtheleteId = atheleteId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sport = sport;
            RegistrationDate = registrationDate;
        }
    }
}
