using QA.SeeSharp.Class07.Domain;
namespace Part2
{
    internal class Action1
    {
        static void Main(string[] args)
        {
            //WheeledVehicle wheeledVehicle = new WheeledVehicle(1, "Audi", "Sadan", 4);
            //Car car = new Car(2, "BMV", "SUV",4,"Black",5);
            Car car1 = new Car(1,"Ford","Mustang",4,"Red",5, FuleType.Petrol);
            Console.WriteLine(car1);
        }
    }
}
