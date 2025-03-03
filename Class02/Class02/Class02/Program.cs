// See https://aka.ms/new-console-template for more information


// Full numbers
Here:
int number;
number = 10;
int num = 10;
//xoxoxoxoxoxoxo
short smallInt = 10;
byte verysmallInt = 10;
long bigINt = 10;
// Floating point numbers
float floatNumber = 10.5f;
double doubleNumber = 12.6d;
decimal decimalNumber = 5.39m;
// Text
char letter = 'C';
string word = "Filip";
//True Flase
bool isValid = false;
bool hasValue = true;

// Primitive objects  !!!! DO NOT USE---EVER!!!!

object obj = 1;
object obj1 = "asdf";
object something = true;

//NEVER /\

int defaultINt = default;
Console.WriteLine(defaultINt);
bool defaultBool = default;
Console.WriteLine(defaultBool);
string defaultString = default;
Console.WriteLine(defaultString);// DEFAULT value is null

string str1 = "";// OK
string str2 = string.Empty;// Better


//// OPERATORS --->
//// ARITMETICS
///


int num1 = 10;
int num2 = num1 + 10;

int num3 = num1 + num2;

int num4 = 10 - 5;
int num5 = num3 - num4;

int num6 = 10 / 5;
double num7 = 10 / 3;

int num8 = 10 * 8;
int num9 = num8 * num1;
int num10 = num9 % num2;
Console.WriteLine(num10);


//int z = int.MaxValue;
//int x = int.MaxValue;
//int c = z + c;
//Console.WriteLine(c);


// num --, -= 1, = num - 1














Console.WriteLine("Test! \nTest!");

Console.WriteLine("^^^^^^\n||||||");

Console.WriteLine("Do you want to start again? y/n");
string goBack = Console.ReadLine();
if( goBack == "y")
{
    goto Here;
}
else
{
    return;
}
