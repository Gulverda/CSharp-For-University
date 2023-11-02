using System;
using System.Collections.Generic;

public abstract class Client
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PersonalNumber { get; set; }

    public abstract void ShowInfo();
    public abstract bool IsInDateInterval(DateTime startDate, DateTime endDate);
}

public class Depositor : Client
{
    public DateTime DateOfOpeningDeposit { get; set; }
    public decimal AmountOfMoney { get; set; }
    public double InterestRate { get; set; }

    public override void ShowInfo()
    {
        Console.WriteLine($"Depositor: {Name} {Surname}");
        Console.WriteLine($"Personal Number: {PersonalNumber}");
        Console.WriteLine($"Date of Opening Deposit: {DateOfOpeningDeposit.ToShortDateString()}");
        Console.WriteLine($"Amount of Money: {AmountOfMoney:C}");
        Console.WriteLine($"Interest Rate: {InterestRate}%");
    }

    public override bool IsInDateInterval(DateTime startDate, DateTime endDate)
    {
        return DateOfOpeningDeposit >= startDate && DateOfOpeningDeposit <= endDate;
    }
}

public class Creditor : Client
{
    public DateTime DateOfIssuanceOfLoan { get; set; }
    public decimal LoanAmount { get; set; }
    public double InterestRate { get; set; }
    public decimal RemainingAmount { get; set; }

    public override void ShowInfo()
    {
        Console.WriteLine($"Creditor: {Name} {Surname}");
        Console.WriteLine($"Personal Number: {PersonalNumber}");
        Console.WriteLine($"Date of Issuance of Loan: {DateOfIssuanceOfLoan.ToShortDateString()}");
        Console.WriteLine($"Loan Amount: {LoanAmount:C}");
        Console.WriteLine($"Interest Rate: {InterestRate}%");
        Console.WriteLine($"Remaining Amount: {RemainingAmount:C}");
    }

    public override bool IsInDateInterval(DateTime startDate, DateTime endDate)
    {
        return DateOfIssuanceOfLoan >= startDate && DateOfIssuanceOfLoan <= endDate;
    }
}

public class Organization : Client
{
    public string IdentificationCode { get; set; }
    public DateTime DateOfOpeningAccount { get; set; }
    public string AccountTitle { get; set; }
    public decimal AccountAmount { get; set; }

    public override void ShowInfo()
    {
        Console.WriteLine($"Organization: {Name}");
        Console.WriteLine($"Identification Code: {IdentificationCode}");
        Console.WriteLine($"Date of Opening Account: {DateOfOpeningAccount.ToShortDateString()}");
        Console.WriteLine($"Account Title: {AccountTitle}");
        Console.WriteLine($"Account Amount: {AccountAmount:C}");
    }

    public override bool IsInDateInterval(DateTime startDate, DateTime endDate)
    {
        return DateOfOpeningAccount >= startDate && DateOfOpeningAccount <= endDate;
    }
}