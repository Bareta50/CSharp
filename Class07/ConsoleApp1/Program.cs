using Part01;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[] {new User(1,"test","test")};
            bool isRunning = true;
            while (isRunning) {
                Console.WriteLine(@"
                1.Register
                2.Login
                3.Exit");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int action)) {
                    switch (action)
                    {
                        case 1:
                            Console.WriteLine("Enter Username: ");
                            string username = Console.ReadLine();
                            Console.WriteLine("Enter Password: ");
                            string password = Console.ReadLine();
                            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                            Register(username, password, users);
                            break;
                        case 2:
                            Console.WriteLine("Enter Username: ");
                            string user = Console.ReadLine();
                            Console.WriteLine("Enter Password: ");
                            string pass = Console.ReadLine();
                            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                            Login(user, pass, users);
                            break;
                        case 3:
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Please choose a valid action");
                            break;
                    }
                        
                        
                        
                        }
                else
                {
                    Console.WriteLine("Please enter a valid action!");
                }
            }

        }

        public static void Register(string username, string password, User[] users) 
        {
            User user = FindUser(username, users);
            if (user != null)
            {
                Console.WriteLine("User already exists!");
                return;
            }
            Array.Resize(ref users, users.Length + 1);
            User newUser = new User(users.Length + 1, username,password);
            users[users.Length - 1] = newUser;

            Console.WriteLine("User registered successfully!");
            Console.WriteLine("-----------------------------");
        }
        public static void Login(string username, string password, User[] users)
        {
            User user = FindUser(username, users);
            if (user == null)
            {
                Console.WriteLine("User not found!");
                return;
            }
            if (user.Password != password)
            {
                Console.WriteLine("Invalid password!");
                return;
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Logged in successfully!");
            Console.WriteLine("-----------------------------");

            foreach(string message in user.Messages)
            {

            }
        }
        public static User FindUser(string username, User[] users)
        {
            foreach (User user in users)
            {
                if (user.UserName.ToLower() == username.ToLower())
                {
                    return user;
                }

            }
            return null;
        }
    }
}
