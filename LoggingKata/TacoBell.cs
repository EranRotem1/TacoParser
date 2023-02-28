using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingKata
{
    public class TacoBell : ITrackable
    {
        public Point Location { get; set; }
        public string Name { get; set; }
        public TacoBell(string name, double lat, double lng) 
        {
            Point location = new Point() { Longitude = lng, Latitude = lat};
            Location = location;
            Name = name;
        }
    }
}
