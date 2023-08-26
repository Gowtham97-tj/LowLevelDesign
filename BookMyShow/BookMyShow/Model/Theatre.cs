using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookMyShow.Model
{
    public class Theatre
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string CityId { get; set; }

        public City City { get; set; }

        public ICollection<Screen> Screens { get; set; }

    }
}
