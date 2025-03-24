using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Exercise
{
    class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public int Age { get; set; }

        public Dog(string name, string breed, string color, int age)
        {
            Name = name;
            Breed = breed;
            Color = color;
            Age = age;
            Console.WriteLine("{0} is a {1} {2}, and is {3} years-old.", name, color,breed,age);
        }

        public string Eat()
        {
            return "The dog is eating!";
        }
        public string Play()
        {
            return "The dog is playing!";
        }

        public string ChaseTail()
        {
            return "The dog is chasing its tail!";
        }
        

    }
}
