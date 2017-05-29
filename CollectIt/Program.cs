using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectIt
{
    // This class is a tool for HashSets to compare emploees. Tells what to compare.
    // Without it, the HashSets are comparing the entire object not knowing that it's the Name we are looking at.
    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            return String.Equals(x.Name, y.Name);
        }

        public int GetHashCode(Employee obj)
        {
            return obj.Name.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Now to comapre employees

            // made as a Dictionary at first, changed to SortedDictionary so it will be always sorted.
            // Changed from list to HashSet so as to prevent duplicates.
            var departments = new SortedDictionary<string, HashSet<Employee>>();

            departments.Add("Sales", new HashSet<Employee>(new EmployeeComparer()));
            departments["Sales"].Add(new Employee { Name = "Florence" });
            departments["Sales"].Add(new Employee { Name = "Mr. Roboto" });
            departments["Sales"].Add(new Employee { Name = "Gerry" });
            departments["Sales"].Add(new Employee { Name = "Mandi" });
            // we don't want there to be duplicates. 
            // Strainght-up HashSet won't work since these are objects of employee. 
            // C# doesn't know how to know that these are the same
            departments["Sales"].Add(new Employee { Name = "Mandi" });

            departments.Add("Engineering", new HashSet<Employee>(new EmployeeComparer()));
            departments["Engineering"].Add(new Employee { Name = "Scott" });
            departments["Engineering"].Add(new Employee { Name = "Joe" });
            departments["Engineering"].Add(new Employee { Name = "Dianne" });

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
