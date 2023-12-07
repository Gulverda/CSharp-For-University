using System;

class ObjectLifecycleExample
{
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Object created.");
        }

        ~MyClass()
        {
            Console.WriteLine("Finalizer called. Object is being reclaimed by the garbage collector.");
        }
    }

    static void Main()
    {
        MyClass obj = new MyClass();
        // Object is used here

        // No need to explicitly destroy the object; the garbage collector will take care of it
    }
}
