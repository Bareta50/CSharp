namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write any number bigger than 2:");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                if(i % 3 == 0)
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
