using HW._09.Booking.Com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com
{
    public  class SearchHotel
    {
        public List<Hotel> ListHotel { get; set; }
        public SearchHotel(List<Hotel> listHotel)
        {
            this.ListHotel = listHotel;
        }
        public  List<Hotel> SearchToCost(int cost)
        {
            var costResult = ListHotel.Where(x => x.ListHotelRooms.Any(y => y.ListApartments.Any(c => c.Cost > 120))).ToList();
            return costResult;
        }
        public List<Hotel> SearchToLocation(string location)
        {
            var cityResult = ListHotel.Where(
                x => x.Location.City.ToUpper().Contains(location)
                || 
                x.Location.Region.ToUpper().Contains(location)
                ||
                x.Location.Address.ToUpper().Contains(location)).ToList();
            return cityResult;
        }
        public List<Hotel> SearchToCountBed(int count)
        {
            var bedResult = ListHotel.Where(x => x.ListHotelRooms.Any(y => y.ListBeds.Count == count)).ToList();
            return bedResult;
               
        }
    }
}
