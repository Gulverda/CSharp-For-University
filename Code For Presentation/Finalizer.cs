using System;

class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Object created.");
    }

    // Destructor (finalizer)
    ~MyClass()
    {
        Console.WriteLine("Object finalized.");
        Dispose(false); // Clean up resources
    }

    // Custom method to release resources
    private void Dispose(bool disposing)
    {
        if (disposing)
        {
            // Release managed resources
            Console.WriteLine("Disposing of managed resources.");
        }

        // Release unmanaged resources
        Console.WriteLine("Disposing of unmanaged resources.");
    }

    // Public method to allow manual resource disposal
    public void Dispose()
    {
        Console.WriteLine("Dispose method called.");
        Dispose(true); // Clean up resources
        GC.SuppressFinalize(this); // Suppress finalization, as resources are already released
    }
}

class Program
{
    static void Main()
    {
        // Creating an object
        MyClass obj = new MyClass();

        // Using the object

        // Manually calling the Dispose method to release resources
        obj.Dispose();

        // The object is now eligible for garbage collection, and the finalizer will run before reclaiming memory
    }
}
