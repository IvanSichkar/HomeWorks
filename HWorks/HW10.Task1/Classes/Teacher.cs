using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task1.Classes
{
    class Teacher:Person
    {
        private string _subject { get; set; }
        public void SetSubject(string subject)
        {
            this._subject = subject;
        }
        public void ShowSubject()
        {
            Console.WriteLine($"Subject is: {_subject}");
        }
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}
