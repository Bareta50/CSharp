using System.Collections;
namespace Class08
{
    internal class Program
    {
        static void GoThrColl(IEnumerable collection, string name)
        {
            Console.WriteLine($"Collection {name}");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            // Arrays

            string[] strings = new string[3];
            string[] str2 = new string[] { "a", "b", "c" };

            // Lists

            List<string> listOfStrings = new List<string>();    
            List<int> listOfNums = new List<int>()
            {
                1,2,3,4,5,6
            };
            //Console.WriteLine(str2.Length);
            //Console.WriteLine(listOfNums.Count);

            //Console.WriteLine(str2[0]);
            //Console.WriteLine(listOfNums[3]);

            // Add elements to the Arrays

            Array.Resize(ref str2 , str2.Length + 1);
            str2[str2.Length - 1] = "d";
            GoThrColl(str2, "str2");
            // Add elements to the Lists

            listOfNums.Add(7);
            listOfNums.Remove(3);
            GoThrColl(listOfNums, "listOfNums");



            // Dictionary

            Dictionary<string, string> UrbanDictionary 
                = new Dictionary<string, string>();
            Dictionary<int, string> DictionaryInt
               = new Dictionary<int, string>();
            UrbanDictionary.Add("$Filip$0409", "I_T_T_F_I_AM");
            UrbanDictionary.Add("Filip", "I am Filip");

            //UrbanDictionary.Add("$Filip$0409", "I_T_T_F_I_AM");
            // ^ wont work, Key must be unique
            //GoThrColl(UrbanDictionary.Keys, "Keys");
            //GoThrColl(UrbanDictionary.Values, "Values");
            //Console.WriteLine(UrbanDictionary["$Filip$0409"]);
            //Console.WriteLine(UrbanDictionary["Filip"]);
            //UrbanDictionary.Remove("$Filip$0409");
            //Console.WriteLine(UrbanDictionary["Filip"]);

            // TryAdd returns a bool

            bool isAddedSuccsess = UrbanDictionary.TryAdd("$Filip$0409", "I_T_T_F_I_AM");
            GoThrColl(UrbanDictionary.Keys, "Keys");


            //Queue (First in First out [FIFO})

            Queue<int> someQueue = new Queue<int>();
            someQueue.Enqueue(25);
            someQueue.Enqueue(5);
            someQueue.Enqueue(2);
            someQueue.Enqueue(14);
            someQueue.Enqueue(7);

            int element = someQueue.Dequeue();
            Console.WriteLine("Element removed: " + element);
            Console.WriteLine(someQueue.Peek());
            GoThrColl(someQueue, "someQueue");
            Console.WriteLine(someQueue.Count);

            //Stack (Last in First out [LIFO])

            Stack<string> someStack = new Stack<string>();
            someStack.Push("First");
            someStack.Push("Second");
            someStack.Push("Third");
            someStack.Push("Fourth");

            string stackElement = someStack.Pop();
            Console.WriteLine("Element removed: " + stackElement);  
            Console.WriteLine(stackElement + " ->{STACK ELEMENT}!!");
            Console.WriteLine(someStack.Peek());
            Console.WriteLine("Length: " + someStack.Count);

            GoThrColl(someStack, "STACK");



            //Console.WriteLine("Hello, World!");
        }
    }
}
