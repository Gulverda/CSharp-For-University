using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a collection of students
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Giorgi", Age = 19 },
            new Student { Id = 2, Name = "Toko", Age = 20 },
            new Student { Id = 3, Name = "Luka", Age = 19 }
        };

        // Create students.xml based on the collection
        CreateXmlFile(students, "students.xml");

        // Read and process the students.xml file using LINQ
        ReadAndProcessXmlFile("students.xml");
    }

    static void CreateXmlFile(List<Student> students, string fileName)
    {
        // Create XML elements based on the Student objects
        XElement studentsXml = new XElement("Students",
            from student in students
            select new XElement("Student",
                new XAttribute("Id", student.Id),
                new XElement("Name", student.Name),
                new XElement("Age", student.Age)
            )
        );

        // Save the XML to a file
        studentsXml.Save(fileName);

        Console.WriteLine($"File '{fileName}' created successfully.");
    }

    static void ReadAndProcessXmlFile(string fileName)
    {
        // Load the XML file
        XDocument doc = XDocument.Load(fileName);

        // Query the XML using LINQ
        var query = from student in doc.Descendants("Student")
                    where (int)student.Element("Age") > 20
                    select new
                    {
                        Id = (int)student.Attribute("Id"),
                        Name = (string)student.Element("Name"),
                        Age = (int)student.Element("Age")
                    };

        // Display the results
        Console.WriteLine("Students older than 20:");
        foreach (var result in query)
        {
            Console.WriteLine($"Id: {result.Id}, Name: {result.Name}, Age: {result.Age}");
        }
    }
}
