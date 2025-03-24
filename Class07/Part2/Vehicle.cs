using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }

        public Vehicle(int id, string model, string type)
        {
            Console.WriteLine("Constructor of Vehicle!");
            ID = id;
            Model = model;
            Type = type;
            Console.Write("{0} / {1} / {2} / ",id,model,type);
        }
        
        public virtual void Start()
        {
            {
                Console.WriteLine("Vehicle is starting!");
            }
        }
    }
}