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
            // Hash set is a kind of collections that doesn't allow duplicates.
            // useful for, say a list of employees and you don't want someone to be added twice.

            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            // it just won't add the second 2 when it sees that it already has that value.
            // the add method will return false to indicate the item wasn't added. True with it is added.
            set.Add(2);

            // cannot index into, never know the order of these.

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            HashSet<Employee> setEmployees = new HashSet<Employee>();
            setEmployees.Add(new Employee { Name = "Scott" });
            // HashSet will not know that these are the same. Tehy are different objects. 
            // There Are ways to make this class. 
            setEmployees.Add(new Employee { Name = "Scott" });

            var employee = new Employee { Name = "Joe" };
            setEmployees.Add(employee);
            // here we only get one be
            setEmployees.Add(employee);

            foreach (var item in setEmployees)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
