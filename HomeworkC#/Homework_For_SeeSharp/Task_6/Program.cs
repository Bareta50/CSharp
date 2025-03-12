namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input num 1^: ");
            int num = int.Parse(Console.ReadLine());
            int sum = default;
            for(int i = 0; i <= num; i++)
            {
                if(i % 5 == 0)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Sum of all numbers that divide 5 {0}", sum);
        }
    }
}
