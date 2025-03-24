namespace Car.Methgods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Driver> drivers = new List<Driver>
            {

                new Driver { Name = "Mark", Skill = 6 },

                new Driver { Name = "Klint", Skill = 5 },

                new Driver { Name = "Aaron", Skill = 7 },

                new Driver { Name = "Timm", Skill = 8 }



            };
            List<Car> cars = new List<Car>
            {


                new Car { Model = "Lada", Speed = 17},

                new Car { Model = "Chevy", Speed = 18},

                new Car { Model = "Audi", Speed = 19},

                new Car { Model = "BMW", Speed = 20}


            };

            Console.WriteLine("Let's Race! Heres the roter.");

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine(@"
               | x x x x x x| x x x x x x|
               | x x __ x x | x x __ x x |
               | x x/  \ xx | x x/  \x x |
               | x x|1 |x x | x x|2 |x x |
               | x x|  |x x | x x|  |x x |
               | x x\__/x x | x x\__/x x |
               | x x x x x x| x x x x x x|
               | x x x x x x| x x x x x x|
               | x x x x x x| x x x x x x|
               | x x/  \x x | x x/  \x x |
               | x x|3 |x x | x x|4 |x x |
               | x x|  |x x | x x|  |x x |
               | x x\__/x x | x x\__/x x |
               | x x x x x x| x x x x x x|
    "); 


            Console.WriteLine("Cars :");

            Console.WriteLine("------");

            int i = 1;

            foreach (var car in cars)
            {

                string message = string.Format("{0}.{1}", i, car.Model);
                Console.WriteLine(message);
                Console.WriteLine("xxxxxxxxx");
                i++;
            }

            i = 1;
            Console.WriteLine("0000000000000000000000000000");

            Console.WriteLine("Drivers :");

            Console.WriteLine("--------");

            foreach (var driver in drivers)
            {
                string message = string.Format("{0}.{1}", i, driver.Name);
                Console.WriteLine(message);
                Console.WriteLine(">>>>>>>");
                i++;
            }

            Console.WriteLine("00");
            Console.WriteLine("00");
            Console.WriteLine("00");
            Console.WriteLine("00");
            Console.WriteLine("Chose a driver for each of the cars (1-5)");
            foreach (var car in cars)
            {
                int driverIndex = int.Parse(Console.ReadLine()) - 1;
                if (driverIndex >= 0 && driverIndex < drivers.Count)
                {
                    car.Driver = drivers[driverIndex];
                    string message = string.Format("{0} is driving the {1}", car.Driver.Name, car.Model);
                    Console.WriteLine(message);
                    Console.WriteLine("[][][][][][][][][][][][][][][][][][][][][][][][][][][]");
                }
                else
                {
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("Invalid driver selection");
                    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXX");
                }

            }

            CalculateSpeed(cars);
            RaceCars(cars);


        }

        static void CalculateSpeed(List<Car> cars)
        {
            foreach (var car in cars)
            {
                int speed = car.Speed * car.Driver.Skill;
                string message = string.Format("{0} is driving the {1} at {2} km/h", car.Driver.Name, car.Model, speed);
                Console.WriteLine(message);
            }
            Console.WriteLine(@"



            ");


        }

        static void RaceCars(List<Car> cars)
        {
            Console.WriteLine("Select what 2 cars you would like to race.");
            int car1Index = int.Parse(Console.ReadLine()) - 1;
            int car2Index = int.Parse(Console.ReadLine()) - 1;

            if (car1Index >= 0 && car1Index < cars.Count && car2Index >= 0 && car2Index < cars.Count)
            {
                Car car1 = cars[car1Index];
                Car car2 = cars[car2Index];

                int speed1 = car1.Speed * car1.Driver.Skill;
                int speed2 = car2.Speed * car2.Driver.Skill;

                Console.WriteLine($"\n{car1.Driver.Name} is racing {car2.Driver.Name}!\n");

                if (speed1 > speed2)
                {
                    Console.WriteLine($"{car1.Driver.Name} wins with a speed of {speed1} km/h!");
                }
                else if (speed2 > speed1)
                {
                    Console.WriteLine($"{car2.Driver.Name} wins with a speed of {speed2} km/h!");
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection of cars.");
            }


           

           
               
        }
    }
}
