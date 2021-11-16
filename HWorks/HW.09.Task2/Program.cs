using System;
using System.Collections.Generic;
using HW._09.Task2.Models;

namespace HW._09.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Film film = new();
            Music music = new Music();
            ComputerProgramm programm = new ComputerProgramm();

            List <object> listFiles= new();
            listFiles.Add(new Film());
            listFiles.Add(new Music());
            listFiles.Add(new ComputerProgramm());

            foreach(var file in listFiles)
            {
                switch(file)
                {
                    case Music m:
                        m.Play();
                        break;
                    case Film f:
                        f.Play();
                        break;
                }
            }
        }
    }
}
