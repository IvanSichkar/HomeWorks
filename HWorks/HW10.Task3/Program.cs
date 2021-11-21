using HW10.Task3.Models;
using System.Linq;
using System;
using System.Collections.Generic;

namespace HW10.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = CreateListemployees();

            foreach (var emp in employees.OrderByDescending(x => x.Experience))
            {
                emp.GetInfo();

                Console.WriteLine($"Требования к { emp.Title}:");
                emp.GetListResponsibility();

                Console.WriteLine(new string('-',25));
            }
        }
        static List<Engineer> CreateListemployees()
        {
            JuniorDeveloper junior = new JuniorDeveloper("Ivan", "Sichkar", 0, "https://github.com/IvanSichkar");
            junior.AddResponsibility("Алгоритмы и структуры данных");
            junior.AddResponsibility("Знание основ C#");
            junior.AddResponsibility("Понимание принципов ООП");
            junior.AddResponsibility("Базовые знаие реляционной БД");

            MiddleDeveloper middle = new MiddleDeveloper("Alex", "Krupskii", 2, "https://github.com/KrupskiiAlex");
            middle.AddResponsibility("Опыт работы от 2 лет");
            middle.AddResponsibility("Уверенное знание C#");
            middle.AddResponsibility("Самостоятельное решение сложных задач");
            middle.AddResponsibility("Умение работать в команде");

            SeniorDeveloper senior = new SeniorDeveloper("Dmitri", "Vasilevskii", 5, "https://github.com/VasilevskiiDmitri");
            senior.AddResponsibility("Опыт работы от 4 лет");
            senior.AddResponsibility("Самостоятельное проектирование систем");
            senior.AddResponsibility("Отличное знане паттернов проектирования");
            senior.AddResponsibility("Помогать Junior-ам и Middl-ам в решении задач");

            TeamLeader teamLead = new TeamLeader("Viktoria", "Aniskovich", 6, "https://github.com/ViktoriaAniskovich");
            teamLead.AddResponsibility("Опыт работы от 3-6 лет");
            teamLead.AddResponsibility("Постановка и распределение задач в команде");
            teamLead.AddResponsibility("Контроль за выполнением (сроки и качество) и приоритизацией задач внутри спринта, обеспечение выполнения целей спринта");
            teamLead.AddResponsibility("Обеспечение рабочей атмосферы внутри команды, обучение, развитие и мотивация команды");

            Architect architect = new Architect("Vadzim", "Papko", 7, "GitHub: https://github.com/VadzimPapko");
            architect.AddResponsibility("Опыт работы архитектором или техническим директором от 3х лет");
            architect.AddResponsibility("Глубокое понимание архитектурных особенностей платформы .Net C#");
            architect.AddResponsibility("Опыт разработки архитектуры сложных / высоконагруженных приложений");
            architect.AddResponsibility("Знание C# на уровне эксперта");

            List<Engineer> employees = new List<Engineer>();
            employees.Add(junior);
            employees.Add(middle);
            employees.Add(senior);
            employees.Add(teamLead);
            employees.Add(architect);

            return employees;
        }
    }
}
