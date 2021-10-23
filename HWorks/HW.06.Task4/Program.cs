using System;
using System.IO;
using System.Text;
namespace HW._06.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int countInvisibleSymb=0;

            StreamReader textReader = new StreamReader(@"C:\Users\ivan\source\Repos\HomeWorks\HWorks\HW.06.Task4\FindMe.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            textReader.Dispose();

            char[] arrayResult = textReaderResult.ToCharArray();

            for(int i=0;i< arrayResult.Length;i++)
            {
                if (Char.IsControl(arrayResult[i]))
                {
                    Console.WriteLine(string.Format("U+{0:X4}", (int)arrayResult[i])+" position "+i);
                    countInvisibleSymb++;
                }                   
            }
            Console.WriteLine("Count invisible symbols: " + countInvisibleSymb);
        }
    }
}
