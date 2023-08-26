using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Model
{
    public class Screen
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TheatreId { get; set; }
        public Theatre Theatre { get; set; }
        public ICollection<Show> shows { get; set; }
    }
}
