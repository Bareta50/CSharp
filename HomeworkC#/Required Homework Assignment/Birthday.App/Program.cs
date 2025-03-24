namespace Birthday.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        Console.WriteLine(@"
              ____     _____        
             |  _ \   |  __ \       __   _
             | |_) |  | |  | | ____ \ \ | | 
             |  _ <|--| |  | |/ _  | \ \| |
             | |_) |  | |__| | (_| |  \   |
             |____/   |_____/ \__,_|   |  |
                                       |  |
                                       |__|
            ");
            AgeCalc();
        }

        static void AgeCalc() 
        { 
           var currentDate = DateTime.UtcNow;
            bool isValidDate = false; 
            while (isValidDate == false)
            {
                Console.Write(@"Input you're date of birth here -->(dd/mm/yyyy)  
----------------------------------------------- :");
                string birthdaay = Console.ReadLine();
                Console.WriteLine("                                                 ^^^^^^^^^^");
                Console.WriteLine("                                                |----------|");



                if (DateTime.TryParse(birthdaay, out DateTime birthDate))
                {
                    var age = currentDate.Year - birthDate.Year;
                   
                    if (currentDate < birthDate.AddYears(age)) age--; //GPT Did this line (Forgot .AddYears(age))
                    Console.WriteLine($"You are {age} years old.");
                    Console.WriteLine("------------------------");
                    isValidDate = true;
                }
                else
                {
                    Console.WriteLine("Invalid date date input --> (dd/mm/yyyy) use [/].");
                    Console.WriteLine("x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x");
                    continue;
                }
            }

        }
    }
}
