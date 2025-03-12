namespace Class05
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //string a = "Filip" + " Velichkovski";
            //string name = "Bob";
            //string lastName = "Bobski";
            //string fullName = name + " " + lastName;
            //Console.WriteLine(fullName + " / " + a );

            ////"Hello name, how are you today";

            //string str = string.Format("Hello {0}, how are you today?", name);
            //Console.WriteLine(str);


            //string str1 = string.Format("Hello {0} {1}, how are you today?", name, lastName);
            //Console.WriteLine(str1);

            //string str2 = $"Hello, this is {a}, and im using INTERPOLATION to write this!";
            //Console.WriteLine(str2);
            //Console.WriteLine("             |             ");
            //Console.WriteLine(" 0-X-0-X-0-X-0-X-0-X-0-X-0 ");
            //Console.WriteLine(" 0-X-0-X-0-X-0-X-0-X-0-X-0 ");
            //Console.WriteLine(" 0-X-0-X-0-X-0-X-0-X-0-X-0 ");
            //Console.WriteLine("             |             ");


            //string str3_2 = @"http:\\google.com";
            //Console.WriteLine(str3_2);
            //Console.WriteLine("             |             ");
            //Console.WriteLine(" 0-X-0-X-0-X-0-X-0-X-0-X-0 ");
            //Console.WriteLine(" 0-X-0-X-0-X-0-X-0-X-0-X-0 ");
            //Console.WriteLine(" 0-X-0-X-0-X-0-X-0-X-0-X-0 ");
            //Console.WriteLine("             |             ");


            //string str4 = @"Check your C:\ drive";
            //string str5 = "We have \"fair\" elections";
            //string str6 = "The\\n signt means :\n new line :)";
            //Console.WriteLine(str4);
            //Console.WriteLine(str5);
            //Console.WriteLine(str6);


            //string str7 = string.Format("{0:C}", 123.456);
            //Console.WriteLine(str7);

            //String Methods

            string ourString = "  We are learing C# and it is fun and easy(!hard!)  ";
            string[] splited = ourString.Split('.', StringSplitOptions.RemoveEmptyEntries);
            foreach (string b in splited)
            {
                Console.WriteLine(b);
                Console.WriteLine("-----");
            }
            //  ^ I do not understand how this works, I need to reasurch more about this topic!!

            string subString = ourString.Substring(2, 17);
            Console.WriteLine(subString);

            char[] chars = ourString.ToCharArray();
            foreach (char items in chars)
            {
                Console.WriteLine(items);
            }




            string s = "hallo world";
            foreach (char c in s)
            {
                Console.WriteLine(System.Convert.ToInt32(c));
            }
        }
    }
}
