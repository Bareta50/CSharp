namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfChars = new string[] { "a", "b", "c", "d" };
            string[] newArray = new string[arrayOfChars.Length];
            int revArr = arrayOfChars.Length-1;
            for(int i = 0; i <= arrayOfChars.Length-1; i++)
            {
                newArray[i] = arrayOfChars[revArr];
                revArr--;
            }
            Console.WriteLine(string.Join(", ",newArray));
        }
    }
}
