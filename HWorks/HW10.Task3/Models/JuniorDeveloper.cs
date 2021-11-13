using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task3.Models
{
    class JuniorDeveloper:Engineer
    {
        public JuniorDeveloper(string firstName, string lastName, int experience, string gitHubReference)
            :base(firstName,lastName,experience,gitHubReference)
        {
            Title = "Junior";
            Id = Guid.NewGuid();
            Responsibility = new List<string>();
            Technologies = new List<string>();
            Responsibility.Add("Английский язык");
        }
        //Company: SaM Solutions, Full Name: Vadzim Papko, Experience: 7,
        //    Title: Architect, Salary: , GitHub: https://github.com/VadzimPapko
    }
}
