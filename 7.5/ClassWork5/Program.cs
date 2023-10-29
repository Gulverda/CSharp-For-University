using EmployeeManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>
            {
                new Worker("John", "Doe", 101, new DateTime(1990, 5, 15), 4500, 4),
                new Worker("Alice", "Smith", 102, new DateTime(1985, 9, 30), 6000, 5),
                new Worker("Bob", "Johnson", 103, new DateTime(1982, 3, 8), 3500, 3),
                new Worker("Eve", "Williams", 104, new DateTime(1995, 7, 20), 5200, 2)
            };

            Console.WriteLine("Original List:");
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker);
            }

            workers.Sort();
            Console.WriteLine("\nSorted by Rating (ascending):");
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker);
            }

            workers.Sort(new WorkerComparerBySalary());
            Console.WriteLine("\nSorted by Salary (ascending):");
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker);
            }

            workers.Sort(new WorkerComparerByAge());
            Console.WriteLine("\nSorted by Age (ascending):");
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker);
            }

            workers.Sort(new WorkerComparerBySalary());
            Console.WriteLine("\nSorted by Salary (ascending) after sorting by Age:");
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker);
            }
        }
    }
}
