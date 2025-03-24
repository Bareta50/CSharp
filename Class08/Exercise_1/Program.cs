using System.Collections.Generic;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Dictionary<string, int> PhoneBook = new Dictionary<string, int>();
            //   PhoneBook.Add("Filip", 123456789);
            //   PhoneBook.Add("Ilina", 987654321);
            //   PhoneBook.Add("Filip_Mali", 567891234);
            //   PhoneBook.Add("Dean", 0987234678);
            //   PhoneBook.Add("Ivan", 123456789);

            //   Console.WriteLine("Enter a name to search for in the phone book:");
            //   string name = Console.ReadLine();
            //   if (PhoneBook.ContainsKey(name))
            //   {
            //       Console.WriteLine(name + " is in the phone book with the number " + PhoneBook[name]);   
            //   }
            //   else
            //   {
            //       Console.WriteLine("ERROR!!!");
            //       Console.WriteLine(name + " is not in the phone book.");
            //   }   
            #endregion

            #region
            
            Person filip = new Person
            {
                ID = 1,
                FirstName = "Filip",
                LastName = "Velichkovski",
                Age = 22,
                FavoriteGenre = Genre.Rock,
                FavoriteSongs  =  new List<Song>
                {
                    new Song("Deutchland", 7, Genre.Rock),
                    new Song("Desiese", 5, Genre.HipHop),
                    new Song("Song3", 5, Genre.Techno),
                    new Song("Song4", 6, Genre.Classical)
                }
            };

            Person nekoj = new Person
            {
                ID = 2,
                FirstName = "Nekojs",
                LastName = "Nekoj",
            };

            nekoj.GetFavSongs();
            Console.WriteLine("X0X0X0X0X0X0X0X0X");
            filip.GetFavSongs();

            #endregion

        }

        
    }
}
