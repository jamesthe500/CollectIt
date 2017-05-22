using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            // The dictionary we made last mod isn't good at sorting.

            // SortedDictionary is an option. It automatically stores in ascending order Wors well for dates, strings ints etc.
            // there are ways to tell it how to sort, not getting into it here.
            var employeesByName = new SortedDictionary<string, List<Employee>>();

            // two lists for HR, one with two other with three
            employeesByName.Add("Sales", new List<Employee> { new Employee(), new Employee(), new Employee() });
            employeesByName.Add("Engineering", new List<Employee> { new Employee(), new Employee() });

            foreach (var item in employeesByName)
            {
                Console.WriteLine("the count of employees in {0} is {1}", 
                    item.Key, item.Value.Count 
                    );
                //Console.WriteLine("hello");
            }


        }
    } 
}
