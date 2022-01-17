using System;

namespace AutomatedProperties
{
    class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class AutomatedPropertiesBase
    {
        public static void Main(string[] args)
        {
            Name name = new Name() { FirstName = "Akash", LastName = "Kumar" };
            Console.WriteLine($"FullName: {name.FirstName}{name.LastName}");
        }
    }
}
