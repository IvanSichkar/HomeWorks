using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com.Models
{
    public class Hotel
    {
        public Location Location { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<HotelRoom> ListHotelRooms { get; set; }
        private double _rating;
        public TypeHotel TypeHotel{ get; set; }
        public double Rating
        {
            get 
            {
                UpdateRating();
                return _rating; 
            }
            private set { _rating = value; }
        }
        public Hotel(Location location,string name,TypeHotel typeHotel,string description="")
        {
            this.Location = location;
            this.Name = name;
            this.TypeHotel = TypeHotel;
            this.ListHotelRooms = new List<HotelRoom>();
        }
        public void AddHotelRoom(HotelRoom hotelRoom)
        {
            ListHotelRooms.Add(hotelRoom);
        }
        private void UpdateRating()
        {
            this.Rating = 5;
        }
    }
    
}
