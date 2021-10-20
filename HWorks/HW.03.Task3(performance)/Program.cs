using System;
using System.Diagnostics;

namespace HW._03.Task3_performance_
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int[] arr = new int[100000000];
            int[] arr2 = new int[100000000];
            int centerArr = arr.Length / 2;
            int lengthArr = arr.Length - 1;
            int buf;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10);
            }
            arr.CopyTo(arr2, 0);

            var startUserReverse = Stopwatch.GetTimestamp();
            for (int i = 0; i < centerArr; i++)
            {
                buf = arr[i];
                arr[i] = arr[lengthArr];
                arr[lengthArr] = buf;
                lengthArr -= 1;
            }
            var stopUserReverse = Stopwatch.GetTimestamp();
           
            var startReverse = Stopwatch.GetTimestamp();
            Array.Reverse(arr2);
            var stopReverse = Stopwatch.GetTimestamp();

            double userReverseTime = stopUserReverse - startUserReverse;
            double reverseTime = stopReverse - startReverse;
            double result = userReverseTime / reverseTime;

            Console.WriteLine("User method   : "+ userReverseTime);
            Console.WriteLine("Reverse method: "+ reverseTime);
            Console.WriteLine("Original reverse "+Math.Round(result,2)+" times faster than User reverse");
        }
    }
}
