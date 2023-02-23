using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripExample.DataModel
{
    public class Driver
    {
        public int Id { get; set; }
        public PersonName FullName { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan StartingExpirience { get; set; }

        public TimeSpan TotalExpirience(DateTime actualMoment) => 
            actualMoment.Subtract(StartDate).Add(StartingExpirience);
//        public virtual ICollection<Trip>? Trips { get; set; }

        public Driver()
        {
//            Trips = new HashSet<Trip>();
        }
    }
}
