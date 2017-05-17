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
            // ctrl rr while on "line" refactor to "queue"
            Queue<Employee> queue = new Queue<Employee>();
            
            queue.Enqueue(new Employee { Name = "Alex " });
            queue.Enqueue(new Employee { Name = "Dani" });
            queue.Enqueue(new Employee { Name = "Johnson" });

            while(queue.Count > 0)
            {
                var employee = queue.Dequeue();
                Console.WriteLine(employee.Name); // will spit out all items in same order entered. FIFO
            }

            Console.WriteLine("----");

            // above is a queue, below is a stack

            Stack<Employee> stack = new Stack<Employee>();

            // hold down to select PhotoShop style
            // stack.Push is the add method for stacks .Pop ro remove
            stack.Push(new Employee { Name = "Alex " });
            stack.Push(new Employee { Name = "Dani" });
            stack.Push(new Employee { Name = "Johnson" });

            while (stack.Count > 0)
            {
                var employee = stack.Pop(); // takes last added, i.e. opposite of queue LIFO
                Console.WriteLine(employee.Name); 
            }

        }
    }
}
