using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string name = GetValidInput("Name", @"^[A-Za-z\s]{1,50}$");
        string surname = GetValidInput("Surname", @"^[A-Za-z\s]{1,50}$");
        string personalNumber = GetValidInput("Personal Number (11 digits)", @"^\d{11}$");
        string dateOfBirth = GetValidInput("Date of Birth (YYYY-MM-DD)", @"^\d{4}-\d{2}-\d{2}$");
        string email = GetValidInput("Email ID", @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$");
        string phoneNumber = GetValidInput("Phone Number (9 digits)", @"^\d{9}$");
        string postalCode = GetValidInput("Postal Code (5 digits)", @"^\d{5}$");
        string website = GetValidInput("Website Address", @"^(https?://)?([A-Za-z_0-9-]+\.)*[A-Za-z_0-9-]+\.[A-Za-z]{2,}(/[A-Za-z_0-9-]+)*/?$");

        Console.WriteLine("\nCollected Information:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Surname: {surname}");
        Console.WriteLine($"Personal Number: {personalNumber}");
        Console.WriteLine($"Date of Birth: {dateOfBirth}");
        Console.WriteLine($"Email ID: {email}");
        Console.WriteLine($"Phone Number: {phoneNumber}");
        Console.WriteLine($"Postal Code: {postalCode}");
        Console.WriteLine($"Website Address: {website}");
    }

    static string GetValidInput(string fieldName, string pattern)
    {
        string userInput;
        do
        {
            Console.Write($"Enter {fieldName}: ");
            userInput = Console.ReadLine();

            if (!Regex.IsMatch(userInput, pattern))
            {
                Console.WriteLine($"Invalid {fieldName} format. Please try again.");
            }
        } while (!Regex.IsMatch(userInput, pattern));

        return userInput;
    }
}
