using HW10.Task1.Classes;
using System;

namespace HW10.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SayHello();

            Student student = new Student();
            student.SetAge(21);
            student.SayHello();
            student.ShowAge();

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.SetSubject("C#");
            teacher.SayHello();
            teacher.ShowSubject();
            teacher.Explain();  
        }
    }
}
