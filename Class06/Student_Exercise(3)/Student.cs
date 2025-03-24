using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Exercise_3_
{
    class Student
    {
        public string Academy { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }

        public Student(string academy, string name, string group)
        {
            Academy = academy;
            Name = name;
            Group = group;
            Console.WriteLine("{0} is in {1} academy, and is in group {2}.", name, academy, group);
        }
    }
}
