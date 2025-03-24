using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Data.Models
{
    public class BaseEnt
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public BaseEnt()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
