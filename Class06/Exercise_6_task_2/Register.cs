using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_task_2
{
    class Register
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Register(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }
    }
}
