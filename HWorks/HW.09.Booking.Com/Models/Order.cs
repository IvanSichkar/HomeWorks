using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com.Models
{
    public class Order
    {
        public User User { get; set; }
        public Apartment Apartament { get; set; }
        public DateTime DateArrival { get; set; }
        public DateTime DateDeparture { get; set; }
        public string PhoneNumber { get; set; }
        public int CountGuest { get; set; }
        public Order(Apartment apartment,int countGuest,DateTime dateArrival,
            DateTime dateDeparture,string phoneNumber,User user=null)
        {
            this.User = user;
            this.Apartament = Apartament;
            this.DateArrival = DateArrival;
            this.DateDeparture = dateDeparture;
            this.PhoneNumber = PhoneNumber;
            this.CountGuest = countGuest;
        }
        public void Save()
        {

        }
    }
}
