using HW10.Task2.Classes;
using System;
using System.Collections.Generic;

namespace HW10.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile music = new MusicFile("Overcome.mp3",1, "Music", 5, "Robert Spurling", 315);

            FilmFile film = new FilmFile("Interstellar.mcv", 2, "Film", 120000,
                "Christopher Nolan", "Matthew McConaughey", "Anne Hathaway");

            ComputerProgram program = new ComputerProgram("HWorks.sln", 3, "Computer programm", 2);

            List <File> files= new List<File>();
            files.Add(music);
            files.Add(film);
            files.Add(program);

            foreach(var file in files)
            {
                file.Play();
            }
        }
    }
}
