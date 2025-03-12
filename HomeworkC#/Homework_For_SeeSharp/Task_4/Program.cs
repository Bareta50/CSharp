namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Intup any number 1->inf:");
            int number = int.Parse(Console.ReadLine());
            //Ova bese greska moja go popraviv kodot
            //int memoryNum = default;
            int sum = default;
            int evilSum = default;
            for (int i = 0; i <=number; i ++)
            {
                
                
                if( i % 2 == 0)
                {
                    //sum = memoryNum + i;
                    //memoryNum = i;
                    //Console.WriteLine(memoryNum);
                    sum += i;
                    //Nekojpati ja iskopliciruvam rabotata
                }
            }
            for (int i = 0; i <= number; i++)
            {


                if (i % 3 == 0)
                {
                  
                    evilSum += i;
                   
                }
            }
            Console.WriteLine("The sum of all even number is: {0}",sum);
            Console.WriteLine("The sum of all odd number is: {0}", evilSum);
        }
    }
}
