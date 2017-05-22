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
            // Dictionary data structure has a key and value. Makes finding data faster.
            //Dictionary<string, Employee> employeesByName = new Dictionary<string, Employee>();
            // Scott likes the var kw in these situations for readability.
            /*
            var employeesByName = new Dictionary<string, Employee>();

            // key values must be unique. you'll get an error if you try to add another with teh same key.
            employeesByName.Add("Scott", new Employee { Name = "Scott Bromander" });
            employeesByName.Add("Joul", new Employee { Name = "Joul Webb" });
            employeesByName.Add("Harry", new Employee { Name = "Harry Flandersen" });

            var scott = employeesByName["Scott"];

            foreach (var item in employeesByName)
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value.Name);
            }
            */

            // here, making it so that each item is actually a list of its own. This solves teh problem of what happens wehn there are two "Scotts".
            var employeesByName = new Dictionary<string, List<Employee>>();

            employeesByName.Add("Scott", new List<Employee>() { new Employee { Name = "Scoot Allen" } });

            // ... other employees are added.

            // need to add another Scott, so instead of adding new, call up the existing key scott, and add to its List
            employeesByName["Scott"].Add(new Employee { Name = "Scott Bromander" });

            foreach (var item in employeesByName)
            {
                foreach (var employee in item.Value)
                {
                    Console.WriteLine(employee.Name);
                }
            }
        }
    } 
}
