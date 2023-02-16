using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripExample.DataModel
{
    public class DriverExpirience
    {
        public int Id { get; set; }
        public TimeSpan Limit { get; set; }
        public double Raise { get; set; }
    }
}
