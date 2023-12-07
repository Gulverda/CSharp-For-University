using System;

// Implementing IDisposable
class MyDisposableClass : IDisposable
{
    private bool disposed = false;

    // Destructor (finalizer)
    ~MyDisposableClass()
    {
        Dispose(false);
    }

    // Implementing IDisposable.Dispose
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // Custom method to release resources
    private void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Release managed resources
                Console.WriteLine("Disposing of managed resources.");
            }

            // Release unmanaged resources
            Console.WriteLine("Disposing of unmanaged resources.");

            disposed = true;
        }
    }

    // Other members and methods of the class...
}

class Program
{
    static void Main()
    {
        // Using the object with the using statement
        using (MyDisposableClass myObject = new MyDisposableClass())
        {
            // Code that uses myObject
        } // The Dispose method is automatically called when leaving the using block
    }
}
