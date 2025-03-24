using System.Collections;

namespace LINQ
{
    internal class Program
    {
        static void PrintDogs(List<Dog> collection)
        {

        }
        static void GoThrColl(IEnumerable collection, string name)
        {
            Console.WriteLine($"Collection {name}");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(){Name = "Sparky", Age = 2},
                new Dog(){Name = "Butch", Age = 1},
                new Dog(){Name = "Zoe", Age = 3},
                new Dog(){Name = "Sia", Age = 1},
                new Dog(){Name = "William", Age = 4},
                new Dog(){Name = "Billy", Age = 1},
                new Dog(){Name = "Buck", Age = 2}
            };

            // All dogs with names longer than 3 characters

            List<Dog> dognameLongerthan3 = new List<Dog>();
            foreach (Dog dog in dogs)
            {
                if (dog.Name.Length > 3)
                {
                    dognameLongerthan3.Add(dog);
                }
            }

            // Where
            List<Dog> filterDogs = dogs.Where(dog => dog.Name.Length > 3).ToList();
            

            // Starts With
            List<Dog> filterDogS = dogs.Where(dog => dog.Name.StartsWith('S')).ToList();

            Dog ageOneStartWB = dogs
                .Where(dog => dog.Age == 1)
                .Where(dog => dog.Name.StartsWith('B'))
                .FirstOrDefault();

            Console.WriteLine(ageOneStartWB.Name);

            // All dog names

            List<string> namesOfDogs = dogs.Select(dog => dog.Name).ToList();   
            GoThrColl(namesOfDogs, "Dog");  


        }

        

    }
}
