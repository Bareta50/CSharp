using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class Car : WheeledVehicle
    {
        public string Color { get; set; }
        public int Doors { get; set; }
        public FuleType Fule { get; set; }

        public Car(int id,string model, string type, int wheels, string colors, int doors, FuleType fule)
            : base(id, model, type, wheels)
        {
            Console.WriteLine("Constructor of car!");
            Color = colors;
            Doors = doors;
            Fule = fule;
            Console.Write("{0} / {1} / {2}",colors,doors,fule);
        }
    }
}
