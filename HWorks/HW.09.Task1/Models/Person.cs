using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1.Models
{
    public class Person
    {
        public string Name { get; set; }
        public House House { get; set; }
        public Person(string name, House house)
        {
            this.Name = name;
            this.House = house;
        }
        public void ShowData()
        {
            Console.WriteLine($"Persoin is {Name}");
            House.ShowData();
            House.ShowDoors();
        }
        public void ShowAppartment()
        {
            Console.WriteLine($"Persoin is {Name}");
            House.SmallApartment.ShowData();
        }
    }
}
