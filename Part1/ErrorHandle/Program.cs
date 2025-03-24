namespace ErrorHandle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new OurCoustumExeption("This is our custom exception");
            }
            catch (OurCoustumExeption ex)
            {
                Console.WriteLine(ex.OurMessage);
            }
        }
    }
}
