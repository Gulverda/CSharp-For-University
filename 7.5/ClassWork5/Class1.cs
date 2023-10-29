using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    class Worker : IComparable<Worker>, IEquatable<Worker>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age => CalculateAge();
        public decimal MonthlySalary { get; set; }
        public int PerformanceRating { get; set; }

        public Worker(string firstName, string lastName, int employeeID, DateTime dateOfBirth, decimal monthlySalary, int performanceRating)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeID = employeeID;
            DateOfBirth = dateOfBirth;
            MonthlySalary = monthlySalary;
            PerformanceRating = performanceRating;
        }

        private int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;
            if (DateOfBirth > today.AddYears(-age)) age--;
            return age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} (Employee ID: {EmployeeID}, Age: {Age}, Monthly Salary: {MonthlySalary:C}, Rating: {PerformanceRating})";
        }

        public int CompareTo(Worker other)
        {
            return this.PerformanceRating.CompareTo(other.PerformanceRating);
        }

        public bool Equals(Worker other)
        {
            return this.EmployeeID == other.EmployeeID;
        }
    }

    class WorkerComparerBySalary : IComparer<Worker>
    {
        public int Compare(Worker x, Worker y)
        {
            return x.MonthlySalary.CompareTo(y.MonthlySalary);
        }
    }

    class WorkerComparerByAge : IComparer<Worker>
    {
        public int Compare(Worker x, Worker y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}