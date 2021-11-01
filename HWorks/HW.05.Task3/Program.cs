using System;
using System.Diagnostics;

namespace HW._05.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =new int[11]{1,2,3,4,5,6,7,8,9,10,11 };
            int centerArr=arr.Length/2;
            int lengthArr = arr.Length-1;

            for(int i=0;i<centerArr;i++)
            {
                int buf = arr[i];
                arr[i] = arr[lengthArr];
                arr[lengthArr] = buf;
                lengthArr -= 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
