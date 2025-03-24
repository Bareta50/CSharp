using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }   

        public string GetPersonStats()
        {
            return FirstName + " " + LastName + " is " + Age + " years old.";
            //string stats = FirstName + " " + LastName + " is " + Age + " years old.";
            //Console.WriteLine(stats);
        }

    }
}
