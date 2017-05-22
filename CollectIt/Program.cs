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
            var employeesByName = new Dictionary<string, Employee>();

            employeesByName.Add("Scott", new Employee { Name = "Scott Bromander" });
            employeesByName.Add("Joul", new Employee { Name = "Joul Webb" });
            employeesByName.Add("Harry", new Employee { Name = "Harry Flandersen" });

            var scott = employeesByName["Scott"];

            foreach (var item in employeesByName)
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value.Name);
            }
        }
    }
}
