using System;


namespace HW._06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = "aa b ccc ffff eee ... ,,,";
            Console.WriteLine("Input string= " + strInput);

            Task1(strInput);
            Task2(strInput);
            Task3(strInput);
            Task4(strInput);
        }

        static void Task1(string strInput)
        {
            string[] arrInput = CreateSortedArrayFromString(strInput);

            strInput= strInput.Replace(arrInput[arrInput.Length - 1]+" ", string.Empty);

            Console.WriteLine("Task1: "+strInput);       
        }

        static void Task2(string strInput)
        {
            string[] arrInput = CreateSortedArrayFromString(strInput);
            string buf = arrInput[arrInput.Length - 1];

            strInput = strInput.Replace(buf, "_");
            strInput = strInput.Replace(arrInput[0], buf);
            strInput = strInput.Replace("_", arrInput[0]);

            Console.WriteLine("Task2: "+strInput);
        }

        static void Task3(string strInput)
        {
            int countLeter=0, countPunctuation=0;
            var charStr = strInput.ToCharArray();

            for (int i=0;i< charStr.Length;i++)
            {
                if (Char.IsLetter(charStr[i]))
                    countLeter++;
                if (Char.IsPunctuation(charStr[i]))
                    countPunctuation++;
            }
            Console.WriteLine("Task 3: Count letter symbols= {0} ; Count punctuation symbols= {1}", countLeter,countPunctuation);
        }

        static void Task4(string strInput)
        {
            string[] arrInput = CreateSortedArrayFromString(strInput);

            Array.Reverse(arrInput);

            Console.WriteLine("Task4: ");
            foreach(var item in arrInput)
            {
                Console.Write(item +" ");
            }
        }

        static string[] CreateSortedArrayFromString(string strInput)
        {
            var arrInput = strInput.Split(" ");
            int[] arr = new int[arrInput.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arrInput[i].Length;
            }

            Array.Sort(arr, arrInput);
            return arrInput;
        }
    }
}
