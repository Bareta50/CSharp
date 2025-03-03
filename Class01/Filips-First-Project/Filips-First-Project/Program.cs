namespace Filips_First_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int enterNum;
            int myAge = 21;
            string name = "Filip", Name;
            char answere;
            Console.WriteLine("         *       ");
            Console.WriteLine("        ***      ");
            Console.WriteLine("       *****     ");
            Console.WriteLine("      *******    ");
            Console.WriteLine("     **     **   ");
            Console.WriteLine("        ***   ");
            Console.WriteLine("       *****   ");
            Console.WriteLine("        ***   ");
            Console.WriteLine("         *    ");
            Console.WriteLine("        ***    ");
            Console.WriteLine("       * * *  ");
            Console.WriteLine("      *  *  *  ");
            Console.WriteLine("     *   *   * ");
            Console.WriteLine("    *   ***   *");
            Console.WriteLine("       *   *");
            Console.WriteLine("      *     *");
            Console.WriteLine("     *       *");
            Console.WriteLine("    *         *");
            Console.WriteLine("   *           *");
            Console.WriteLine("x[]x[]x[]x[]x[]x[]x[]x[]x[]x[]x");
            Console.WriteLine("Hello, this is my first C# program.");
            Console.WriteLine(" I will try to use if statements and a while loop.");
            Console.WriteLine("x[]x[]x[]x[]x[]x[]x[]x[]x[]x[]x");


            Console.WriteLine("Do you want to proceed: (y/n)? ");
            answere = Console.ReadLine()[0];
            if(answere == 'y')
            {
                Console.WriteLine("Guess my name: I'm the father of a Great General long ago. Who am I");
                Name = Console.ReadLine();
                if (Name == name){
                    Console.WriteLine("Good Good, Now my Age?");
                    enterNum = int.Parse(Console.ReadLine());
                    
                    
                    if (enterNum == myAge)
                    {
                        Console.WriteLine("Congrats, You successfuly finished my if else program.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You Failed! womp womp");
                        return;
                    }

                }
            //    else {
            //        Console.WriteLine("You Failed! womp womp");
            //        return;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("You Failed! womp womp");
            //    return;
            }



































        }
    }
}
