using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandle
{
    internal class OurCoustumExeption : Exception
    {
        public string OurMessage { get; set; }
        public OurCoustumExeption(string message)
        {
            OurMessage = message;
        }
    }
}
