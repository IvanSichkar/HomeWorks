using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1.Models
{
    public class House
    {
        private int _area;
        private List<Door> _listDoor;
        public SmallAppartment SmallApartment { get; set; }
        public int Area
        {
            get => _area;
            private set => _area = value < 0 ? 0 : value;
        }
        public House(int area)
        {
            this.Area = area;
            this._listDoor = new List<Door>();
            this.SmallApartment = new();
        }
        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {Area} m2");
        }
        public void AddDoor(Door door)
        {
            _listDoor.Add(door);
        }
        public void ShowDoors()
        {
            foreach(var door in _listDoor)
            {
                door.ShowData();
            }
        }
        public class SmallAppartment
        {
            public int Area { get; private set; }
            public SmallAppartment()
            {
                this.Area = 50;
            }
            public void ShowData()
            {
                Console.WriteLine($"I am a SmallAppartment, my area is {Area} m2");
            }
        }

    }
}
