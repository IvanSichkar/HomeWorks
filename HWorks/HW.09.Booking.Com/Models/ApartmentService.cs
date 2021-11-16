using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com.Models
{
    public class ApartmentService
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public ApartmentService(string name,int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
