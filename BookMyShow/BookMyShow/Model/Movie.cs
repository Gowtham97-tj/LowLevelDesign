using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Model
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ShowId { get; set; }
        public Show Show { get; set; }
    }
}
