//Console.WriteLine("Input a number: ");
//int number1 = int.Parse(Console.ReadLine());
//for(int i =1; i <= number1; i++)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("XOXOXOXOXOXOXOXXOXOXOXOXOXOX");

//for (int i =number1; i>= 1; i--)
//{
//    Console.WriteLine(i);
//}

Console.WriteLine("Enter a number :");

int num3 = int.Parse(Console.ReadLine());
Console.WriteLine("===========================================");



Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
for (int b = 0; b <= num3; b++)
{
    if (b % 3 == 0 || b % 7 == 0)
    {
        continue;
    }
    if (b == 100)
    {
        Console.WriteLine(b);
        Console.WriteLine("Limit reached!");
        Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
        Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
        Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
        Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
        Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
        break;
    }
    Console.WriteLine(b);

}




for (int i = 0; i <= num3 ; i +=2) { 
{
    
    Console.WriteLine(i);
    if (i >= num3)
    {
        Console.WriteLine("-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=--==-");
        for (int a = 0; a <= num3; a++)
        {
            if (a % 2 == 0)
            {
                continue;
            }
            Console.WriteLine(a);

            //if (a >= num3)
            //{
            //    Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
            //    for (int b = 0; b <= num3; b++)
            //    {
            //        if (b % 3 == 0 || b % 7 == 0)
            //        {
            //            continue;
            //        }
            //        if (b == 100)
            //        {
            //            Console.WriteLine(b);
            //            Console.WriteLine("Limit reached!");
            //            break;
            //        }
            //        Console.WriteLine(b);
                    
            //    }
            }
        }
    }
}


