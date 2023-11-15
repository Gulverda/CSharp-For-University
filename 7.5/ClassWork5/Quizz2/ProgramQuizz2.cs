using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace qvizi
{
    class Program
    {
        static void Main()
        {
            // Create a list of publications instead of an array
            List<Publication> publications = new List<Publication>
        {
            new Book
            {
                Title = "Sample Book",
                Authors = new string[] { "John Doe" },
                YearOfPublication = 2020,
                Publisher = "Publisher A",
                NumberOfPages = 200
            },
            new Article
            {
                Title = "Sample Article",
                Authors = new string[] { "Jane Smith" },
                YearOfPublication = 2021,
                JournalName = "Journal X",
                VolumeNumber = 3,
                PagesQuantity = 15
            },
            new ElectronicResource
            {
                Title = "Sample Electronic Resource",
                Authors = new string[] { "Sam Johnson" },
                Link = "https://example.com",
                Annotation = "This is a sample electronic resource."
            }
            // Add more publications as needed
        };

            // Display information about all editions (sorted by title)
            var sortedPublications = publications.OrderBy(p => p.Title);
            foreach (var publication in sortedPublications)
            {
                publication.DisplayDetailedInfo();
                Console.WriteLine("------------------------------");
            }

            // Activate the search engine to display information within a date range
            int startYear = 2019;
            int endYear = 2022;
            Console.WriteLine($"Publications within the date range {startYear}-{endYear}:");
            var publicationsInRange = publications.Where(p => p.IsInDateRange(startYear, endYear));
            foreach (var publication in publicationsInRange)
            {
                publication.DisplayDetailedInfo();
                Console.WriteLine("------------------------------");
            }
        }
    }


}