using System;

namespace HW._05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert value");
            int sizeRow = Convert.ToInt32(Console.ReadLine());

            if (sizeRow > 100 || sizeRow < 0)
                return;

            int sizeColumn = sizeRow;
            int value = 1;
            string[,] arrStr= new string[sizeRow, sizeColumn];

            int startColumn = 0;

            for (int iR = 0; iR < sizeRow; iR++)
            {
                for (int iC = startColumn; iC < sizeColumn; iC++)
                {
                    arrStr[iR, iC] = value.ToString();
                }
                startColumn += 1;
                value += 1;
                if (value == 10)
                    value = 0; 
            }

            for(int i=0;i<sizeRow;i++)
            {
                for(int j=0;j<sizeColumn;j++)
                {
                    Console.Write(" "+arrStr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
