namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write any number (2 -> 999):  ");
            //Da ne stavam i za iljada
            int number = int.Parse(Console.ReadLine());
            int hundreds = default;
            int ones = default;
            int tens = default;
            int result;
            if (number >= 10)
            {
                 ones = number % 10;
                 tens = number / 10;

                result = tens * ones;
                Console.WriteLine(result);
                
            }
            else if (number >= 100)
            {
                ones = number % 10;
                tens = number / 10;
                hundreds = number / 100;

                result = hundreds * tens * ones;
                Console.WriteLine(result);
            }
            else if (number < 10)
            {
                int res = number * number;
                Console.WriteLine("{0} is a single didget number and canot be multiplied.\n However if it is multiplied by itselfe it wil be: {1}", number, res);
            }
                
        }
    }
}
