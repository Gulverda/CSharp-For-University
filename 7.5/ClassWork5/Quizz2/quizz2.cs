using System;
using System.Collections.Generic;
using System.Linq;

// Abstract class Publication
public abstract class Publication
{
    public string Title { get; set; }
    public string[] Authors { get; set; }
    public int YearOfPublication { get; set; }

    // DisplayDetailedInfo is an abstract method that must be implemented by the derived classes.
    public abstract void DisplayDetailedInfo();

    // IsInDateRange is a method that checks if the publication is within a given date range.
    public abstract bool IsInDateRange(int startYear, int endYear);
}

// Book class (inherits from Publication)
public class Book : Publication
{
    public string Publisher { get; set; }
    public int NumberOfPages { get; set; }

    // DisplayDetailedInfo method provides information specific to a book.
    public override void DisplayDetailedInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Authors: {string.Join(", ", Authors)}");
        Console.WriteLine($"Year of Publication: {YearOfPublication}");
        Console.WriteLine($"Publisher: {Publisher}");
        Console.WriteLine($"Number of Pages: {NumberOfPages}");
    }

    // IsInDateRange method checks if the book is within a given date range.
    public override bool IsInDateRange(int startYear, int endYear)
    {
        return YearOfPublication >= startYear && YearOfPublication <= endYear;
    }
}

// Article class (inherits from Publication)
public class Article : Publication
{
    public string JournalName { get; set; }
    public int VolumeNumber { get; set; }
    public int PagesQuantity { get; set; }

    // DisplayDetailedInfo method provides information specific to an article.
    public override void DisplayDetailedInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Authors: {string.Join(", ", Authors)}");
        Console.WriteLine($"Journal Name: {JournalName}");
        Console.WriteLine($"Volume Number: {VolumeNumber}");
        Console.WriteLine($"Year of Publication: {YearOfPublication}");
        Console.WriteLine($"Pages Quantity: {PagesQuantity}");
    }

    // IsInDateRange method checks if the article is within a given date range.
    public override bool IsInDateRange(int startYear, int endYear)
    {
        return YearOfPublication >= startYear && YearOfPublication <= endYear;
    }
}

// ElectronicResource class (inherits from Publication)
public class ElectronicResource : Publication
{
    public string Link { get; set; }
    public string Annotation { get; set; }

    // DisplayDetailedInfo method provides information specific to an electronic resource.
    public override void DisplayDetailedInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Authors: {string.Join(", ", Authors)}");
        Console.WriteLine($"Link: {Link}");
        Console.WriteLine($"Annotation: {Annotation}");
    }

    // IsInDateRange method for electronic resources may not have a specific year of publication.
    // You can modify this method as per your requirements.
    public override bool IsInDateRange(int startYear, int endYear)
    {
        // Electronic resources may not have a specific year of publication
        // You can modify this method as per your requirements
        return true;
    }
}

