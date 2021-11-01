using System;
using System.Text;

namespace HW._06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputText = "gdfgdf234dg54gf/23oP42".ToCharArray();

            StringBuilder sbBeforeAction = new StringBuilder();
            StringBuilder sbAfterAction = new StringBuilder();
            int indexMathAction=0;
            
            
            for(int i=0;i< inputText.Length;i++)
            {
                if (Char.IsDigit(inputText[i]))
                    sbBeforeAction.Append(inputText[i]);

                //42 - '*'    43 - '+'    45 - '-'    47 - '/'   
                if (inputText[i] == (char)42 || inputText[i] == (char)43 ||
                   inputText[i] == (char)45 || inputText[i] == (char)47)
                {
                    indexMathAction = i;
                    break;
                }   
            }

            for (int i=indexMathAction+1;i<inputText.Length;i++)
            {
                if (Char.IsDigit(inputText[i]))
                    sbAfterAction.Append(inputText[i]);
            }

            MathAction(Convert.ToInt32(sbBeforeAction.ToString()),
                        Convert.ToInt32(sbAfterAction.ToString()), 
                        inputText[indexMathAction]);
        }
        static void MathAction(int value1,int value2,char action)
        {
            switch (action)
            {   //42 - '*'    43 - '+'    45 - '-'    47 - '/' 
                case (char)42:
                    Console.WriteLine( value1 * value2);
                    break;
                case (char)43:
                    Console.WriteLine(value1 + value2);
                    break;
                case (char)45:
                    Console.WriteLine(value1 - value2);
                    break;
                case (char)47:
                    Console.WriteLine(Convert.ToDouble(value1) / Convert.ToDouble(value2));
                    break;
            }
        }
    }
}
