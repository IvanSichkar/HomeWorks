using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task3.Models
{
    class TeamLeader:Engineer
    {
        public override int Salary1 { get => base.Salary1 * 8 + 500; }
        public TeamLeader(string firstName, string lastName, int experience, string gitHubReference)
           : base(firstName, lastName, experience, gitHubReference)
        {
            Title = "TeamLeader";
            Id = Guid.NewGuid();
            Responsibility = new List<string>();
            Technologies = new List<string>();
            Responsibility.Add("Английский язык");
            SetSelary2();
        }
        public override int SetSelary2()
        {
            return base.SetSelary2() *8 + 500;
        }
    }
}
