using System;

namespace HW._05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert arrays length:");
            Int32.TryParse(Console.ReadLine(), out int arrLength);

            int[] arr = new int[arrLength];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Insert " + i + " value:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int valuePaste = arr[arr.Length - 1];

            Console.WriteLine("Insert new position in array for value "+arr[arr.Length-1]);
            int indexPaste = Convert.ToInt32(Console.ReadLine());

            ShowArray("Input array: ",arr);

            int[] arrNew=GenerateNewArray(arr, valuePaste, indexPaste);

            ShowArray("Result array: ", arrNew);
        }
        static void ShowArray(string message,int[] array)
        {
            Console.WriteLine(message);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static int[] GenerateNewArray(int[] arrayInput,int number, int index)
        {
            int[] arrNew=new int[arrayInput.Length];

            for (int i = 0; i < index; i++)
            {
                arrNew[i] = arrayInput[i];
            }

            arrNew[index] = number;

            for (int i = index; i < arrayInput.Length - 1; i++)
            {
                arrNew[i + 1] = arrayInput[i];
            }

            return arrNew; 
        }
    }
}
