namespace Dog_Exercise
{
    internal class Glavna
    {
        static void Main(string[] args)
        {
            Dog Jingles = new Dog("Jingles", "Pitbul", "Dark-Brown", 4);
            Console.WriteLine("What does {0} do? (Eat,PLay or ChaseTail)", Jingles.Name);
            string action = Console.ReadLine();
            switch (action)
            {
                case "Eat":
                    Console.WriteLine(Jingles.Eat());
                    break;
                case "Play":
                    Console.WriteLine(Jingles.Play());
                    break;
                case "ChaseTail":
                    Console.WriteLine(Jingles.ChaseTail());
                    break;
            }

        }

    }
}
