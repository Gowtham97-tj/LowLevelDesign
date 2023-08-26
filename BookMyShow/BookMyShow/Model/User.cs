using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string email { get; set; }
        public ICollection<Seat> seats { get; set; } 

    }
}
