using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInC_
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void DepartmentTable()
        {
            IEnumerable<Department> departments = new List<Department>()//IEnumerable returns a collection that can be enmerated
            {
                new Department { Id = 1, Name = "Music" },
                new Department { Id = 2, Name = "Business",},
                new Department { Id = 3, Name = "Music", },

            };

            var joinEmployeesAndDepartments = employees.join( //we were trying to join the employees and department table
                departments,
                emp => emp.Department,
                dept => dept.Name,
                (emp, dept) => new { emp.Name, Department = dept.Name });

            Console.WriteLine("The join for the Employees and Departments are:");
            foreach (var joinedemployeedept in joinEmployeesAndDepartments)
            {
                Console.WriteLine($"{joinedemployeedept.Name} : {joinedemployeedept.Department}");
            }
        }


    }

    /*internal class employees  i tried fixing the error at employees.join using the ctrl+.
    {
        internal static IEnumerable<object> join(IEnumerable<Department> departments, Func<object, object> value1, Func<object, object> value2, Func<object, object, object> value3)
        {
            throw new NotImplementedException();
        }
    }*/
}
