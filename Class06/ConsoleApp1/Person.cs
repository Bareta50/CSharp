namespace ConsoleApp1
{
    internal class Person
    {
        static void Main(string[] args)
        {

            Human person1 = new Human();
            person1.FirstName = "John";
            person1.LastName = "Doe";
            person1.Age = 52;

            Console.WriteLine(person1.GetPersonStats());

            Plane plane1 = new Plane("Boing747", 200, "Boing", "White", true);
           
        }

    }
}
