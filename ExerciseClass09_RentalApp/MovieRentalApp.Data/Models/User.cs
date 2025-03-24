using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Data.Models
{
    public class User : BaseEnt
    {
        public string FullName { get; set; }
        public DateTime DateOFBirth { get; set; }
        public int CardNumber { get; set; }
        public bool isSubscriptionEx { get; set; }
        public DateTime SubscriptionExpirationDate { get; set; }


    }
}
