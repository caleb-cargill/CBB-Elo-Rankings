using System;
namespace CBB_Elo_Ratings.Data.Models
{
	public class Stadium
	{
        public int StadiumID { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public object Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public object Zip { get; set; }
        public object Country { get; set; }
        public int Capacity { get; set; }
        public double GeoLat { get; set; }
        public double GeoLong { get; set; }
    }
}

