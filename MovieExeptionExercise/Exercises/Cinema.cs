using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Cinema
    {
        public string Name { get; set; }
        public int Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public Cinema(string name, int halls, List<Movie> movies)
        {
            Name = name;
            Halls = halls;
            Movies = movies;
        }

        public void MoviePlaying(string movie)
        {
            string watching = string.Format("You are watching {0}", movie);
            Console.WriteLine(watching);    
        }

    }
}
