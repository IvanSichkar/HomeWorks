using System;

namespace HW._05.GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHour = DateTime.Now.Hour;

            Console.WriteLine(HeelowMessage(currentHour));

            string HeelowMessage(int currentHour) =>
            currentHour switch
            {
                (>= 9) and (< 12) => "Good morning, guys",
                (>=12)and (< 15) => "Good day, guys",
                (>= 15) and (< 22) => "Good evening, guys",
                ((>=22)and(<=24)) or((>= 0) and (< 9)) =>"Good night, guys",
                (<0)or(> 24)=> "Error",
            };
        }
    }
}
