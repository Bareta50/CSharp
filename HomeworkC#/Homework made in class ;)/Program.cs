
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