using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectIt
{
    // Added iComparer inheritance, since we need to be able to compare in order to sort.
    public class EmployeeComparer : IEqualityComparer<Employee>, 
                                    IComparer<Employee>
    {
        
        public int Compare(Employee x, Employee y)
        {
            // returns an int -1, 0, or 1. 1st is less than, same, 1st is greater than.
            return String.Compare(x.Name, y.Name);
        }

        public bool Equals(Employee x, Employee y)
        {
            return String.Equals(x.Name, y.Name);
        }

        public int GetHashCode(Employee obj)
        {
            return obj.Name.GetHashCode();
        }
    }

    // This class cleans up the code, by bringing some of the mess up here.
    public class DepartmentCollection : SortedDictionary<string, SortedSet<Employee>>
    {
        public DepartmentCollection Add(string departmentName, Employee employee)
        {
            // check if the department already exists
            if (!ContainsKey(departmentName))
            {
                // if not, add it annew.
                Add(departmentName, new SortedSet<Employee>(new EmployeeComparer()));

            }
            // here youre guaranteed that the departmetn is a key inside this collection.
            // just need to ref that sorted set and add that employee.
            this[departmentName].Add(employee);
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var departments = new DepartmentCollection();

            // with teh new class, no longer need this department adding line
            //departments.Add("Sales", new SortedSet<Employee>(new EmployeeComparer()));
            // and can use teh new way the method works. less clunky
            // just, departments.Add instead of referenceing an established department. 
            // And it adds it only if needed
            departments.Add("Sales", new Employee { Name = "Florence" })
                       .Add("Sales", new Employee { Name = "Mr. Roboto" })
                       .Add("Sales", new Employee { Name = "Gerry" })
                       .Add("Sales", new Employee { Name = "Mandi" })
                       .Add("Sales", new Employee { Name = "Mandi" });

            //departments.Add("Engineering", new SortedSet<Employee>(new EmployeeComparer()));
            departments.Add("Engineering", new Employee { Name = "Scott" })
                       .Add("Engineering", new Employee { Name = "Joe" })
                       .Add("Engineering", new Employee { Name = "Dianne" });

            foreach (var department in departments)
            {
                Console.WriteLine(department.Key);
                foreach (var employee in department.Value)
                {
                    Console.WriteLine("\t" + employee.Name);
                }
            }


        }
    } 
}
