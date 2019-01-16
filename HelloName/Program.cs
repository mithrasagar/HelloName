using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare string 
            string name = "Mithra Sagar";
            // Display name in console
            Console.WriteLine(name);
            // Prompt user to hit any key to dismiss console
            Console.WriteLine("Hit any key to dismiss");
            // Dismiss console once user hits key
            Console.ReadKey(true);
        }
    }
}
