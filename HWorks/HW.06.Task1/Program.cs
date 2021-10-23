using System;
using System.Globalization;
namespace HW._06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert poem:");
            string poem = Console.ReadLine();

            string[] arrPoem = poem.Split(";");

            for(int i=0;i<arrPoem.Length;i++)
            {
                arrPoem[i]=arrPoem[i].Replace("o", "a",true,CultureInfo.CurrentCulture);
            }

            Console.WriteLine("Edit poem:");
            foreach (var item in arrPoem)
            {
                Console.WriteLine(item);
            }
        }
    }
}
