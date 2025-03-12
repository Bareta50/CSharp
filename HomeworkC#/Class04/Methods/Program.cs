using System.Runtime.InteropServices;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (1 < 2)
            {
                string YESNO;
                //
                Console.Write("Chose an opperation[(+)Sum : (-)Subtract--->:");
                string operandChoice = Console.ReadLine();
                //
                Console.Write("Enter the first number->:");
                string num1 = Console.ReadLine();
                bool x1 = double.TryParse(num1, out double number1);
                Console.WriteLine(number1);
                Console.WriteLine(x1);
                //
                Console.Write("Enter the second number->:");
                string num2 = Console.ReadLine();
                bool x2 = double.TryParse(num2, out double number2);
                Console.WriteLine(number2);
                Console.WriteLine(x2);
                //
                if (operandChoice == "+")
                {
                   
                    Console.WriteLine(Sum(number1, number2));

                    Console.WriteLine("Do you want to try again? (y/n)");
                    YESNO = Console.ReadLine();

                    if (YESNO == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            
                //
                else if (operandChoice == "-")
                {
                    
                    Console.WriteLine(Subtract(number1, number2));
                    Console.WriteLine("Do you want to try again? (y/n)");
                    YESNO = Console.ReadLine();
                    if (YESNO == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                //
                else
                {
                    Console.WriteLine("Please enter a valid input. (+) or (-)!");
                    continue;
                }
            }



        }
        public static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }
        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

      
    }
}
