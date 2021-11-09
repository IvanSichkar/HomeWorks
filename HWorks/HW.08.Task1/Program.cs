using System;
using System.Text;

namespace HW._08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("1a!2.3!!.. 4.!.? 6 7! .. ?");
            int firstEqualsIndex = 0;

            for(int i=0;i<sb.Length;i++)
            {
                if (sb[i].Equals('!') || sb[i].Equals('.'))
                {
                    sb.Remove(i, 1);
                    i--;
                }
                if (sb[i].Equals('?'))
                {
                    firstEqualsIndex = i;
                    break;
                }
            } 
            
            sb.Replace(' ', '_', firstEqualsIndex, sb.Length - firstEqualsIndex);

            Console.WriteLine(sb);
        }
    }
}
