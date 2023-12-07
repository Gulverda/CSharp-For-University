using System;

class CheckedUncheckedExample
{
    static void Main()
    {
        try
        {
            checked
            {
                int result = int.MaxValue + 1; // This will throw an OverflowException
                Console.WriteLine(result);
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Overflow Exception: {ex.Message}");
        }

        unchecked
        {
            int result = int.MaxValue + 1; // This will wrap around (no exception)
            Console.WriteLine(result);
        }
    }
}
