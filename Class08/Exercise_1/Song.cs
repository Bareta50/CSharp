using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Song
    {
        public string Tital { get; set; }
        public int Length { get; set; }
        public Genre Genre { get; set; }

        public Song(string tital, int length, Genre genre)
        {
            Tital = tital;
            Length = length;
            Genre = genre;
        }

    }
}
