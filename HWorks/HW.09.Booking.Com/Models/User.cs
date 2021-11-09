using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com.Models
{
    public class User
    {
        public string Email { get; set; }
        public User(string Email)
        {
            this.Email = Email;
        }
    }
}
