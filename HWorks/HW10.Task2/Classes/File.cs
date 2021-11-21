using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task2.Classes
{
    class File
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string Category { get; set; }
        public int Size { get; set; }
        public File(string name, int code, string category, int size)
        {
            this.Name = name;
            this.Code = code;
            this.Category = category;
            this.Size = size;
        }
        public virtual void Play() { }
    }
}
