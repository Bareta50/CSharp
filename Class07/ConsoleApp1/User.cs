using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public User()
        {
            Messages = new string[1];
        }
        public User(int id, string username, string password)
        {
            ID = id;
            UserName = username;
            Password = password;
            Messages = new string[3] {"Hello","Bye","Hi"};

        }
    }
}
