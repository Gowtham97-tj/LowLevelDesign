using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Model
{
    public class Show
    {
        public Guid Id { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public Screen Screen { get; set; }
        public Guid ScreenId { get; set; }
        public Movie movie { get; set; }
        public ICollection<Seat> seats { get; set; }
    }
}
