using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInC_
{
   /* LINQ
    * linq queries include where, join etc
Language Integrated Query, it allows developers to query and manipulate data from different data sources
ORM: Object Oriented Mapper
POCO: plan old CLR(Common Lnaguage Runtime) Objects
In LINQ we have client side evaluation and server side evaluation.In client side data is stored in lists and dictionaries while server side data is stored in SQL database.
Object relational mapper (ef core) allows u to map your linq queries to sql queries that ur database understands
Ef core is a object relational mapper that allows you to map your class to a database table.
Landa expressions are anonymous methods.It is called arrow functions in JavaScript*/

    internal class LearningLINQ
    {
        /*class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public int Salary { get; set; }
        }*/

       /* class Department
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }*/

        public void ManipulateLINQ()
        {
            /*IEnumerable<Employee> employees = new List<Employee>()//IEnumerable returns a collection that can be enmerated
            {
                new Employee { Id = 1, Name = "Winner", Department = "Music", Salary = 50000},
                new Employee { Id = 2, Name = "Brandon", Department = "Game", Salary = 40000},
                new Employee { Id = 3, Name = "MaryAnn", Department = "Business", Salary = 20000},
                new Employee { Id = 4, Name = "Don", Department = "Money", Salary = 100000},
                new Employee { Id = 5, Name = "Mara", Department = "Cooking", Salary = 70000},
                new Employee { Id = 6, Name = "Micheal", Department = "Microsoft", Salary = 90000},
            };*/

            /*var musicEmployee = employees.Where(emp => emp.Department == "Music"); // this is your linq employees.Where(emp => emp.Department == "Music"); and emp => emp.Department is the landa exoression which will return a predicate
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
            }*/

            /*IEnumerable<Department> departments = new List<Department>()//IEnumerable returns a collection that can be enmerated
            {
                new Department { Id = 1, Name = "Music" },
                new Department { Id = 2, Name = "Business",},
                new Department { Id = 3, Name = "Music", },

            };*/

            /*var joinEmployeesAndDepartments = employees.Join( //we were trying to join the employees and department table
                departments,
                emp => emp.Department,
                dept => dept.Name,
                (emp, dept) => new { emp.Name, Department = dept.Name });

            Console.WriteLine("The join for the Employees and Departments are:");
            foreach (var joinedemployeedept in joinEmployeesAndDepartments)
            {
                Console.WriteLine($"{joinedemployeedept.Name} : {joinedemployeedept.Department}");
            }*/
        }
    }
}
