using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task2.Classes
{
    class MusicFile:File
    {
        public string Singer { get; set; }
        public int Length { get; set; }
        public MusicFile(string name, int code,string category,int size,
            string singer,int length):base(name,code,category,size)
        {
            this.Singer = singer;
            this.Length = length;
        }
        public override string ToString()
        {
            return $"{Name}, {Code}, {Category}, {Size}, {Singer}, {Length}";
        }
        public override void Play()
        {
            Console.WriteLine(ToString());
        }
    }
}
