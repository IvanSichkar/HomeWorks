using System;
using HW._09.Task1.Models;

namespace HW._09.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new House(120);
            house.AddDoor(new Door("Red"));
            house.AddDoor(new Door("Green"));

            Person person = new Person("Sichkar Ivan",house);
            person.ShowData();
            person.ShowAppartment();
        }
    }
}
