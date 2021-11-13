using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task3.Models
{
    class SeniorDeveloper:Engineer
    {
        public override int Salary1 { get => base.Salary1 * 5+300;  }
        public SeniorDeveloper(string firstName, string lastName, int experience, string gitHubReference)
           : base(firstName, lastName, experience, gitHubReference)
        {
            Title = "Senior";
            Id = Guid.NewGuid();
            Responsibility = new List<string>();
            Technologies = new List<string>();
            Responsibility.Add("Английский язык");
            SetSelary2();
        }
        public override int SetSelary2()
        {
            return base.SetSelary2()*5+300;
        }
    }
}
