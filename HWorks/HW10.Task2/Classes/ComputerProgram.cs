using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task2.Classes
{
    class ComputerProgram:File
    {
        public ComputerProgram(string name, int code, string category, int size)
            :base(name,code,category,size)
        {
            this.Name = name;
            this.Code = code;
            this.Category = category;
            this.Size = size;
        }
        public override string ToString()
        {
            return $"{Name}, {Code}, {Category}, {Size}";
        }
        public override void Play()
        {
            Console.WriteLine(ToString());
        }
    }
}
