namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4, 2.5);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2.5);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2.5);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2.5);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2.5);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2.5);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4, 2.5);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4, 2.5);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4, 2.5);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2.5);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2.5);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2.5);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2.5);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2.5);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2.5);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4, 2.5);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4, 2.5);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4, 2.5);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };

            Cinema cinema1 = new Cinema("Cineplexx", 5, MovieSet1);
            Cinema cinema2 = new Cinema("CineStar", 5, MovieSet2);
            bool isWorking = true;
            while (isWorking)
            {
                Console.WriteLine("Choose Cinema :");
                string cinemaChoice = Console.ReadLine();
                string input;
                if (cinemaChoice == "Cineplexx")
                {
                    Console.WriteLine("AllMovies or by Ganre :");
                    while (true) { 
                    input = Console.ReadLine();
                    if (input == "AllMovies")
                    {
                        foreach (var movie in cinema1.Movies)
                        {
                            Console.WriteLine(movie.Title);
                               

                        }
                        break;
                        }
                    else if (input == "by Ganre")
                    {
                        Console.WriteLine("WIP");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            continue;
                        }
                }

                    string movieChoice = Console.ReadLine();
                    cinema1.MoviePlaying(movieChoice);
                    isWorking = false;
                }
                else if (cinemaChoice == "CineStar")
                {
                    Console.WriteLine("AllMovies or by Ganre :");
                    while (true)
                    {
                        input = Console.ReadLine();
                        if (input == "AllMovies")
                        {
                            foreach (var movie in cinema1.Movies)
                            {
                                Console.WriteLine(movie.Title);


                            }
                            break;
                        }
                        else if (input == "by Ganre")
                        {
                            Console.WriteLine("WIP");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            continue;
                        }
                    }
                    Console.WriteLine("xxxxxxxxxxxx");
                    Console.WriteLine("Choose a movie to watch");
                    string movieChoice = Console.ReadLine();
                    cinema2.MoviePlaying(movieChoice);
                    isWorking = false;
                }
                else
                {
                    Console.WriteLine("Invalid Cinema");
                    continue;
                }
            }
        }
    }
}
