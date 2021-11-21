using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task1.Classes
{
    class Person
    {
        public int Age { get; set; }
        public void SetAge(int age)
        {
            this.Age = age;
        }
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}
