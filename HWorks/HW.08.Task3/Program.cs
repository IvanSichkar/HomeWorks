using System;
using System.Text;
using System.Text.RegularExpressions;

namespace HW._08.Task3
{
    class Program
    {
        static void Main(string[] args)
        { 
            string addresses = "123 Main Street St.Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432";
            
            Travel(addresses, "OH 43071");
            Travel(addresses, "NY 56432");
            Travel(addresses, "NY 5643");
        }
        static void Travel(string addresses,string zipCode)
        {
            string[] arrayInput = addresses.Split(',');

            string[] arrayHouseNumbers = new string[arrayInput.Length];
            string[] arrayAddress = new string[arrayInput.Length];
            int countEntrys = 0;
            StringBuilder sb = new StringBuilder();

            for (int i=0;i<arrayInput.Length;i++)
            {
                if (arrayInput[i].LastIndexOf(zipCode) == arrayInput[i].Length-zipCode.Length)   
                {
                    countEntrys++;
                   
                    sb.Append(arrayInput[i]);

                    int indexFirstSpace = arrayInput[i].IndexOf(' ');
                    arrayHouseNumbers[i]=sb.Remove(indexFirstSpace, arrayInput[i].Length - indexFirstSpace).ToString();

                    sb.Clear();
                    sb.Append(arrayInput[i]);
                    sb.Remove(arrayInput[i].IndexOf(zipCode)-1, zipCode.Length+1);
                    sb.Remove(arrayInput[i].IndexOf(arrayHouseNumbers[i]), arrayHouseNumbers[i].Length+1);

                    arrayAddress[i] = sb.ToString();
                    sb.Clear();
                }
            }
            if(countEntrys == 0)
            {
                Console.WriteLine(zipCode + ":/");
                return;
            }
                
            StringBuilder sbReult = new StringBuilder();
            sbReult.Append(zipCode+":");

            for(int i=0;i< arrayAddress.Length;i++)
            {
                if(arrayAddress[i]!= null)
                    sbReult.Append(arrayAddress[i] + ",");
            }

            sbReult.Remove(sbReult.Length - 1, 1);//remove last ','
            sbReult.Append("/");

            for(int i=0;i<arrayHouseNumbers.Length;i++)
            {
                if (arrayHouseNumbers[i] != null)
                    sbReult.Append(arrayHouseNumbers[i] + ",");
            }

            sbReult.Remove(sbReult.Length - 1, 1);//remove last ','

            Console.WriteLine(sbReult);
        }
    }
}
