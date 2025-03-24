using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Person
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteGenre { get; set; }

        public List<Song> FavoriteSongs { get; set; }

        public Person()
        {
            FavoriteSongs = new List<Song>();
        }

        public void GetFavSongs()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine("No favorite songs.");
                return;
            }
            else
            {
                foreach (var song in FavoriteSongs)
                {
                    Console.WriteLine(song.Tital);
                }
            }
        }



    }
}
