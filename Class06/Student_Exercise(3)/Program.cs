namespace Student_Exercise_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student("Qinshift", "Filip" , "G3"),
                new Student("Qinshift", "Igor" , "G3"),
                new Student("Qinshift", "Ivan" , "G3"),
            };

            string name = Console.ReadLine();
            bool isFound = false;
            foreach (Student student in students)
            {
                if (student.Name == name) 
                { Console.WriteLine("Student {0} is in database", name);
                    isFound = true; break;
                    
                }
            }

            if (!isFound)
            {
                Console.WriteLine("Student {0} is not in database", name);
            }


        }
    }
}
