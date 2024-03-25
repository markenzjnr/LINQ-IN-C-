using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client Side LINQ Execution in C#....");
            Employee employee = new Employee();
            employee.EmployeesTable();

            Department department = new Department();
            department.DepartmentTable();
         /*   LearningLINQ lq = new LearningLINQ();
            lq.ManipulateLINQ();*/
        }
    }
}
