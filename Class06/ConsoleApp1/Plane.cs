using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Plane
    {
        public Plane() {
         Console.WriteLine("This is a plane."); 
        }
        public Plane(string name)
        {
            Name = name;
            Type = "Boeing";
            CanFly = false;

        }

        public Plane(string name, int seats,string type, string color, bool canfly)
        {
            name = name;
            SeatCapacity = seats;
            Type = type;
            color = color;
            CanFly = canfly;
            Console.WriteLine(name+" ("+type + ") , Seating Capacity: [" + seats + "] , " + color + " , CanFly:" + canfly);
        }

        public string Color { get; set; }
        public string Type { get; set; }
        public bool CanFly { get; set; }    
        public string Name { get; set; }    
        public int SeatCapacity { get; set; }
    }
}
