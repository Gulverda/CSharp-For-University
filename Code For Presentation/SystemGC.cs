using System;

class GarbageCollectionExample
{
    class MyObject
    {
        public int Value { get; set; }

        public MyObject(int value)
        {
            Value = value;
            Console.WriteLine($"Object {Value} created.");
        }

        ~MyObject()
        {
            Console.WriteLine($"Object {Value} finalized.");
        }
    }

    static void Main()
    {
        // Creating objects
        MyObject obj1 = new MyObject(1);
        MyObject obj2 = new MyObject(2);

        // Setting obj1 to null, making it eligible for garbage collection
        obj1 = null;

        // Forcing garbage collection (Note: This is usually not necessary in real applications)
        GC.Collect();
        GC.WaitForPendingFinalizers();

        // Creating a new object
        MyObject obj3 = new MyObject(3);

        // Demonstrating GetGeneration method
        Console.WriteLine($"Generation of obj1: {GC.GetGeneration(obj1)}");
        Console.WriteLine($"Generation of obj2: {GC.GetGeneration(obj2)}");
        Console.WriteLine($"Generation of obj3: {GC.GetGeneration(obj3)}");

        // Demonstrating TotalMemory property
        Console.WriteLine($"Total memory before collection: {GC.GetTotalMemory(false)} bytes");

        // Forcing garbage collection for Generation 0
        GC.Collect(0);

        // Demonstrating TotalMemory property after collection
        Console.WriteLine($"Total memory after collection: {GC.GetTotalMemory(false)} bytes");

        // Creating more objects
        MyObject obj4 = new MyObject(4);
        MyObject obj5 = new MyObject(5);

        // Demonstrating KeepAlive method
        GC.KeepAlive(obj4);

        // The program will exit, and the garbage collector will finalize any remaining objects
    }
}
