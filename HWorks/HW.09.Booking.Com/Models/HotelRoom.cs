using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com.Models
{
    public class HotelRoom
    {
       public string Name { get; set; }
       public List<string> ListServices { get; set; }
       public List<string> ListBeds { get; set; }
       public List<Apartment> ListApartments { get; set; }
        public HotelRoom(string name,List<string> listBad)
        {
            this.Name = name;
            this.ListBeds = listBad;
            this.ListApartments = new List<Apartment>();
        }
        public void AddApartment(Apartment apartment)
        {
            ListApartments.Add(apartment);
        }
    }
}
