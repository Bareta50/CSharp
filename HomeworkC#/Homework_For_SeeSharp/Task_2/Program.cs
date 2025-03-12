namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input any number bigger than 5: ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 2; i <= number; i++)
            {
                if(i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
