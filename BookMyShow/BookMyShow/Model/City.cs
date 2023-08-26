using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookMyShow.Model
{
    public class City
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Theatre> theatres { get; set; }
    }
}
