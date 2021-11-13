using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task2.Classes
{
    class FilmFile:File
    {
        public string Director { get; set; }
        public string MainActor { get; set; }
        public string MainActress { get; set; }
        public FilmFile(string name, int code, string category, int size,
          string director, string  mainActor,string mainActress) : base(name, code, category, size)
        {
            this.Director = director;
            this.MainActor = mainActor;
            this.MainActress = mainActress;
        }
        public override string ToString()
        {
            return $"{Name}, {Code}, {Category}, {Size}, {Director}, {MainActor}, {MainActress}";
        }
        public override void Play()
        {
            Console.WriteLine(ToString());
        }
    }
}
