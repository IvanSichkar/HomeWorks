using System;

namespace HW._05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert arrays length:");
            Int32.TryParse(Console.ReadLine(), out int arrLength);

            Console.WriteLine("Insert top bound of random numbers:");
            Int32.TryParse(Console.ReadLine(), out int topBound);

            int[] arrRandom = new int[arrLength];
            int[] arrUser = new int[arrLength];
            int[] arrSum = new int[arrLength];

            Random rnd = new Random();

            for(int i = 0; i < arrRandom.Length; i++)
            {
                arrRandom[i] = rnd.Next(0, topBound);
            }

            for(int i = 0; i < arrUser.Length; i++)
            {
                Console.WriteLine("Insert "+ i + " value:");
                arrUser[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < arrSum.Length; i++)
            {
                arrSum[i] = arrRandom[i] + arrUser[i];
            }

            ShowResult(arrRandom,arrUser,arrSum);
        }
        static void ShowResult(int[] arrRandom,int[] arrUser,int[] arrSum)
        {
            Console.WriteLine("Result:");
            Console.Write("Random array: ");
            for (int i=0;i<arrRandom.Length;i++)
            {
                Console.Write(arrRandom[i]+" ");
            }
            Console.WriteLine();
            Console.Write("User array:   ");
            for (int i = 0; i < arrUser.Length; i++)
            {
                Console.Write(arrUser[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Sum array:    ");
            for (int i = 0; i < arrSum.Length; i++)
            {
                Console.Write(arrSum[i] + " ");
            }
        }
    }
}
