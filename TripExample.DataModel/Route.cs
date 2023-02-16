namespace TripExample.DataModel
{
    public class Route
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Distance { get; set; }
        public TimeSpan MeanDuration {  get; set; }
        public decimal Cost { get; set; }

        public virtual ICollection<Trip>? Trips { get; set; }

        public Route()
        {
            Trips = new HashSet<Trip>();
        }
    }
}