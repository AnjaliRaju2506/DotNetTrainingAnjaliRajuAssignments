using System;

class Program
{
    static void Main()
    {
        string input = "123";
        int number;

        bool success = int.TryParse(input, out number);

        if (success)
        {
            Console.WriteLine("Parsed successfully: " + number);
        }
        else
        {
            Console.WriteLine("Parsing failed.");
        }
    }
}
