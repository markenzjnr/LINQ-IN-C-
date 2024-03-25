using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInC_
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        public void EmployeesTable ()
        {
            IEnumerable<Employee> employees = new List<Employee>()//IEnumerable returns a collection that can be enmerated
            {
                new Employee { Id = 1, Name = "Winner", Department = "Music", Salary = 50000},
                new Employee { Id = 2, Name = "Brandon", Department = "Game", Salary = 40000},
                new Employee { Id = 3, Name = "MaryAnn", Department = "Business", Salary = 20000},
                new Employee { Id = 4, Name = "Don", Department = "Money", Salary = 100000},
                new Employee { Id = 5, Name = "Mara", Department = "Cooking", Salary = 70000},
                new Employee { Id = 6, Name = "Micheal", Department = "Microsoft", Salary = 90000},
            };
            var musicEmployee = employees.Where(emp => emp.Department == "Music"); // this is your linq employees.Where(emp => emp.Department == "Music"); and emp => emp.Department is the landa exoression which will return a predicate
            Console.WriteLine("The employee in the Music department are :");
            foreach (var musicemployee in musicEmployee)
            {
                Console.WriteLine(musicemployee.Name);
            }

            Console.WriteLine("The employees and their salaries are:");
            var employeeSalaries = employees.OrderBy(emp => emp.Salary); //so the orderby here which is a linq operators just liek where sorts the elements in a sequence according to the key which is the lambda expression emp => emp.Salary
            foreach (var employeeSalary in employeeSalaries)
            {
                Console.WriteLine($"{employeeSalary.Name} : {employeeSalary.Salary}");
            }

        }


    }
}
