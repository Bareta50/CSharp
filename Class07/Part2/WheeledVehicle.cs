using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class WheeledVehicle : Vehicle
    {
       public int Wheels { get; set; }
        public WheeledVehicle(int id, string model, string type, int wheels)
            : base(id, model, type)
        {
            Console.WriteLine("Constructor of WheeledVehicle!");
            Wheels = wheels;
            Console.Write("{0} / ",wheels);
        }
    }
}
