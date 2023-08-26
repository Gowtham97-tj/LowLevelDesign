using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Model
{
    public class Seat
    {
        public Guid Id { get; set; }
        public int SeatNo { get; set; }
        public Guid ShowId { get; set; }
        public Show Show { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public bool IsOccupied { get; set; }
    }
}
