using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripExample.DataModel
{
    public class Trip
    {
        public int Id { get; set; }
        public virtual Route? Route { get; set; }
        public virtual Driver? Driver { get; set; }

        public DateTime Started { get; set; }
        public DateTime Finished { get; set; }
        public decimal Reward {  get; set; }
        public decimal Bonus { get; set; }
    }
}
