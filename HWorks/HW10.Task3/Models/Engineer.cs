using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task3.Models
{
    abstract class Engineer
    {
        public Guid Id { get; protected set; }
        public string Title { get; protected set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual int Salary1 { get; protected set ; }
        public int Salary2 { get; protected set; }
        public int Experience { get; set; }
        public List<string> Responsibility { get; set; }
        public List<string> Technologies { get; set; }
        public string GitHubReference { get; set; }
        public Engineer(string firstName, string lastName, int Experience, string gitHubReference)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Experience = Experience;
            this.GitHubReference = gitHubReference;
            SetSalary1();
            Salary2 = SetSelary2();
        }
        public virtual void GetInfo() 
        {
            Console.WriteLine($"Company: {Company.Name}, Full Name: {FirstName} {LastName}, Experience: {Experience}," +
                $"Title: {Title}, Salary1: {Salary1}, Salary2: {Salary2}, GitHub: {GitHubReference}");
        }
        private void  SetSalary1()
        {
            Salary1= 500;
        }
        public virtual int SetSelary2()
        {
            return 500;
        }
        public void AddResponsibility(string responsibility)
        {
            Responsibility.Add(responsibility);
        }
        public void AddTechnologies(string technology)
        {
            Technologies.Add(technology);
        }
        public void GetListResponsibility()
        {
            foreach (var resp in Responsibility.GetRange(0, 5))
            {
                Console.WriteLine($"-{ resp}");
            }
        }
    }
}
