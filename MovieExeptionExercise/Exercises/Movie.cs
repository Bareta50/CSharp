using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating, double ticketPrice)
        {
            if (rating < 1 || rating > 5)
            {
                throw new ArgumentException("Rating must be between 0 and 5.");
            }
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = ticketPrice;
        }
    }
}
