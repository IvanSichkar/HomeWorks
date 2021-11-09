using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1.Models
{
    public class Door
    {
        public string Color { get; set; }
        public Door(string color)
        {
            this.Color = color;
        }
        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {Color}");
        }
    }
}
