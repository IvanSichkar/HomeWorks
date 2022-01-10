using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.Task2.Models
{
    public class Motorcycle
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometr { get; set; }
        public Motorcycle(int id,string name,string model,int year,int odometr)
        {
            Id = id;
            Name = name;
            Model = model;
            Year = year;
            Odometr = odometr;
        }
    }
}
