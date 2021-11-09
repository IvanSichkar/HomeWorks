using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2.Models
{
    class Film
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string Category { get; set; }
        public double Size { get; set; }
        public string Director { get; set; }
        public string MainActor { get; set; }
        public string MainActress { get; set; }
        public override string ToString()
        {
            return $"Film :{Name}, Code:{Code}, Category: {Category}," +
                $" Size:{Size}, Director:{Director}, MainActor:{MainActor}," +
                $" MainActress{MainActress}.";
        }
        public void Play()
        {
           Console.WriteLine(ToString());
        }
    }
}
