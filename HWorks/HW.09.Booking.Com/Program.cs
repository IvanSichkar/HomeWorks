using System;
using System.Collections.Generic;
using System.Linq;
using HW._09.Booking.Com.Models;

namespace HW._09.Booking.Com
{
    class Program
    {
        static List<Hotel> CreateListHotel()
        {
            Location location1 = new Location();
            location1.Country = "Россия";
            location1.Region = "Ростовская область";
            location1.City = "Волгодонск";
            location1.Address = "улица Отдыха 39Б";

            Hotel hotel1 = new Hotel(location1, "Гостиница Донская Волна", TypeHotel.Отель);


            List<string> listBed = new List<string>() { "двуспальная кровать", "огромная двуспальная кровать" };
            HotelRoom hotelRoom1 = new HotelRoom("Большой двухместный номер с 2 кроватями", listBed);

            hotel1.AddHotelRoom(hotelRoom1);

            Apartment apartment1 = new Apartment(2, 100);
            apartment1.AddApartmentService(new ApartmentService("Завтрак", 20));
            hotelRoom1.AddApartment(apartment1);

            Apartment apartment2 = new Apartment(2, 100);
            apartment2.AddApartmentService(new ApartmentService("Завтрак", 20));
            apartment2.AddApartmentService(new ApartmentService("Ужин", 20));

            hotelRoom1.AddApartment(apartment2);
            ///////////////////////////////////////////////////////////////////////

            Location location2 = new Location();
            location2.Country = "Украина";
            location2.Region = "Львовская область";
            location2.City = "Львов";
            location2.Address = "tomashivskogo St, 7 ";

            Hotel hotel2 = new Hotel(location2, "Lwow House", TypeHotel.Квартира);

            List<string> listBed2 = new List<string>() { "большая двуспальная кровать", "двуспальная кровать", "диван - кровать" };
            HotelRoom hotelRoom2 = new HotelRoom("Апартаменты с 2 спальнями", listBed2);

            hotel2.AddHotelRoom(hotelRoom2);

            Apartment apartment3 = new Apartment(4, 200);
            hotelRoom2.AddApartment(apartment1);

            List<Hotel> listHotel = new List<Hotel>();
            listHotel.Add(hotel1);
            listHotel.Add(hotel2);
            return listHotel;
        }
        static void Main(string[] args)
        {
            var listHotel = CreateListHotel();

            var searchHotel = new SearchHotel(listHotel);
            var costResult = searchHotel.SearchToCost(100);
            //var bedSearch = searchHotel.SearchToCountBed(2);

            var selectedApartment = costResult.FirstOrDefault().ListHotelRooms.FirstOrDefault().ListApartments.FirstOrDefault();

            var Order = new Order(selectedApartment,2, Convert.ToDateTime("10.11.2021"), Convert.ToDateTime("12.11.2021"),"80445677697");
            Order.Save();
        }
    }
}
