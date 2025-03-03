// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region y/n While loop with if/else
//while (1 < 2)
//{
//Console.WriteLine("Write two numbers: ");
//int nuberGuess = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//if (nuberGuess == num2)
//{
//    Console.WriteLine("Their the same- 1: "+nuberGuess+"__- 2: "+num2);
//    return;
//}
//else if (nuberGuess < num2 )
//{
//    Console.WriteLine("The number "+nuberGuess+" is smaller than "+num2);
//    if (num2 % 2 == 0)
//    {
//        Console.WriteLine("Btw, the number " + num2 + " is EVEN");
//    }
//    else if (num2 % 2 != 0)
//    {
//        Console.WriteLine("Btw, the number " + num2 + " is ODD");
//    }
//    continue;
//}
//else if (nuberGuess > num2)
//{
//    Console.WriteLine("The number " + nuberGuess + " is larger than " + num2);
//    if (nuberGuess % 2 == 0)
//    {
//        Console.WriteLine("Btw, the number " + nuberGuess + " is EVEN");
//    }
//    else if (nuberGuess % 2 != 0)
//    {
//        Console.WriteLine("Btw, the number " + nuberGuess + " is ODD");
//    }
//    continue;

//    }

//}
#endregion

#region trees-baskets
//int branches = 12;
//int apples = 8;
//int maxCApOfBasket = 5;
//int trees;
//int result;
//Console.WriteLine("Enter how many trees you want to pick, max apples per basket: ");
//trees = int.Parse(Console.ReadLine());
//result = trees * (branches * apples) / maxCApOfBasket;
//Console.WriteLine("You'll need this many baskets: "+result);
#endregion

#region Switch

while (1 < 2)
{

    double num1;
    double num2;
    double result;
    string opperation;
    Console.WriteLine("Simple Calculator, enter two number then the opperation you want to do(+,-,*,/,%)");
    num1 = double.Parse(Console.ReadLine());
    num2 = double.Parse(Console.ReadLine());
    opperation = Console.ReadLine();
    switch (opperation)
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine("Result: " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine("Result: " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine("Result: " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine("Result: " + result);
            break;
        case "%":
            result = num1 % num2;
            Console.WriteLine("Result: " + result);
            break;

    }
    Console.WriteLine("Do you want to do another calculation? (y/n) :");
    string choice = Console.ReadLine();
    if (choice == "y")
    {
        continue;
    }
    else
    {
        return;
    }
}
#endregion

#region 

#endregion