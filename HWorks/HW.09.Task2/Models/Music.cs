using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2.Models
{
    class Music
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string Category { get; set; }
        public double Size { get; set; }
        public string Singer { get; set; }
        public int Length { get; set; }
        public override string ToString()
        {
            return $"Music :{Name}, Code:{Code}, Category: {Category}," +
                $" Size:{Size}, Singer:{Singer}, Length:{Length}.";
        }
        public void Play()
        {
            Console.WriteLine(ToString());
        }
    }
}
