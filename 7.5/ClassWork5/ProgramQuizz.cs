using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>
        {
            new Depositor
            {
                Name = "John",
                Surname = "Doe",
                PersonalNumber = "123456789",
                DateOfOpeningDeposit = new DateTime(2023, 1, 15),
                AmountOfMoney = 50000,
                InterestRate = 2.5
            },
            new Creditor
            {
                Name = "Alice",
                Surname = "Smith",
                PersonalNumber = "987654321",
                DateOfIssuanceOfLoan = new DateTime(2023, 3, 10),
                LoanAmount = 100000,
                InterestRate = 5.0,
                RemainingAmount = 75000
            },
            new Organization
            {
                Name = "ABC Inc.",
                IdentificationCode = "789012345",
                DateOfOpeningAccount = new DateTime(2023, 2, 5),
                AccountTitle = "Business Account",
                AccountAmount = 200000
            }
        };

            // Show information about all clients
            Console.WriteLine("Information about all clients:");
            foreach (var client in clients)
            {
                client.ShowInfo();
                Console.WriteLine();
            }

            // Sort clients by decreasing debt (for creditors)
            var creditors = clients.OfType<Creditor>().OrderByDescending(c => c.RemainingAmount).ToList();

            Console.WriteLine("Information about creditors sorted by decreasing debt:");
            foreach (var creditor in creditors)
            {
                creditor.ShowInfo();
                Console.WriteLine();
            }

            // Search mechanism by date interval
            DateTime startDate = new DateTime(2023, 1, 1);
            DateTime endDate = new DateTime(2023, 2, 28);

            Console.WriteLine("Information about clients who started cooperating within the specified date interval:");
            foreach (var client in clients)
            {
                if (client.IsInDateInterval(startDate, endDate))
                {
                    client.ShowInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
