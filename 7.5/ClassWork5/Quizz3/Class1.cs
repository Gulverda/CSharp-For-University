using System;
using System.Linq;

public abstract class Software
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public DateTime ReleaseDate { get; set; }

    public abstract void DisplayInfo();

    public abstract bool IsSuitable();
}

public class Free : Software
{
    public Free(string name, string manufacturer, DateTime releaseDate)
    {
        Name = name;
        Manufacturer = manufacturer;
        ReleaseDate = releaseDate;
    }

    public override void DisplayInfo()
    {
        //throw new NotImplementedException();
        Console.WriteLine($"Free Software: {Name},\n Manufacturer: {Manufacturer},\n Release Date: {ReleaseDate.ToShortDateString()}");
    }

    public override bool IsSuitable()
    {
        return true;
    }
}

public class Trial : Software
{
    public DateTime InstallDate { get; set; }
    public int FreePeriodMonth { get; set; }

    public Trial(string name, string manufacturer, DateTime releaseDate, DateTime installDate, int freePeriodMonths)
    {
        Name = name;
        Manufacturer = manufacturer;
        ReleaseDate = releaseDate;
        InstallDate = installDate;
        FreePeriodMonth = freePeriodMonths;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Trial Software: {Name},\n Manufacturer: {Manufacturer},\n Release Date: {ReleaseDate.ToShortDateString()},\n Install Date: {InstallDate.ToShortDateString()},\n Free Period: {FreePeriodMonth} months");

    }

    public override bool IsSuitable()
    {
        return DateTime.Now < InstallDate.AddMonths(FreePeriodMonth);

    }
}

public class Commercial : Software
{
    public decimal Price { get; set; }
    public DateTime InstallDate { get; set; }
    public int TermOfUseMonths { get; set; }

    public Commercial(string name, string manufacturer, DateTime releaseDate, decimal price, DateTime installDate, int termOfUseMonths)
    {
        Name = name;
        Manufacturer = manufacturer;
        ReleaseDate = releaseDate;
        Price = price;
        InstallDate = installDate;
        TermOfUseMonths = termOfUseMonths;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Commercial Software: {Name},\n Manufacturer: {Manufacturer}, \n Release Date: {ReleaseDate.ToShortDateString()},\n Price: {Price:C},\n Install Date: {InstallDate.ToShortDateString()},\n Term of Use: {TermOfUseMonths} months");

    }

    public override bool IsSuitable()
    {
        return DateTime.Now < InstallDate.AddMonths(TermOfUseMonths);
    }
}