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
            Queue<Employee> line = new Queue<Employee>();
            // with a QQueue there is no add nor insert method, so use Enqueue
            line.Enqueue(new Employee { Name = "Alex " });
            line.Enqueue(new Employee { Name = "Dani" });
            line.Enqueue(new Employee { Name = "Johnson" });

            // the whole point is you get things out as you put them in so no accessing by:
            // line[0]... etc.

            // Dequeue gives you the first item in teh line and deletes it from queue at teh same time
            // line.Dequeue ...

            // to get everything, use a loop
            while(line.Count > 0)
            {
                var employee = line.Dequeue();
                Console.WriteLine(employee.Name); // will spit out all items in same order entered. FIFO
            }
        }
    }
}
