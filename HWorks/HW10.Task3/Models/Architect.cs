using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task3.Models
{
    class Architect:Engineer
    {
        public override int Salary1 { get => base.Salary1 * 12 + 1000; }
        public Architect(string firstName, string lastName, int experience, string gitHubReference)
           : base(firstName, lastName, experience, gitHubReference)
        {
            Title = "Architect";
            Id = Guid.NewGuid();
            Responsibility = new List<string>();
            Technologies = new List<string>();
            Responsibility.Add("Английский язык");  
        }
        public override int SetSelary2()
        {
            return base.SetSelary2() * 12 + 1000;
        }
    }
}
