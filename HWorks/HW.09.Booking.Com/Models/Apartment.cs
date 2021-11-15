using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com.Models
{
    public class Apartment
    {
        public int CountPersons { get; set; }
        public int Cost { get; set; }
        public List<ApartmentService> ListApartmentServices { get; set; }
        public Apartment(int countPersons,int cost)
        {
            this.CountPersons = countPersons;
            this.Cost = cost;
            this.ListApartmentServices = new();
        }
        public void AddApartmentService(ApartmentService apartmentService)
        {
            ListApartmentServices.Add(apartmentService);
            UpdatePrice(apartmentService.Cost);
        }
        private void UpdatePrice(int cost)
        {
            this.Cost += cost;
        }
    }
}
