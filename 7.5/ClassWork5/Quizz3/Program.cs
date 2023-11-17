using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Software[] softwareArray = new Software[]
            {
            new Free("FreeSoftware1", "ManufacturerA", DateTime.Parse("2022-01-01")),
            new Trial("TrialSoftware1", "ManufacturerB", DateTime.Parse("2022-03-01"), DateTime.Parse("2022-08-01"), 3),
            new Commercial("CommercialSoftware1", "ManufacturerC", DateTime.Parse("2022-03-01"), 99.99m, DateTime.Parse("2024-04-01"), 6),
            };

            Console.WriteLine("All Software Information (Ascending order by days until expiration):");
            var sortedSoftware = softwareArray.OrderBy(s => s.IsSuitable()).ThenBy(s => s.ReleaseDate);
            foreach (var software in sortedSoftware)
            {
                software.DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Not Expired Software Information:");
            var notExpiredSoftware = softwareArray.Where(s => s.IsSuitable());
            foreach (var software in notExpiredSoftware)
            {
                software.DisplayInfo();
                Console.WriteLine();
            }
        }
    }

}
