using RentalApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Data.Models
{
    public class Movie : BaseEnt
    {
        public string Title { get; set; }

        public Genre Genre { get; set; }

        public string Language { get; set; }

        public bool IsAvailable { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Length { get; set; }
        public int AgeRestriction { get; set; }
        public int Quantity { get; set; }

    }
}
