using System.Reflection;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a class named Car - make sure it is public
            // In the Car class:
            // Create a Make property of type string that is public
            // Create a Model property of type string that is public
            // Create a Year property of type int that is public

            // In the Main method:
            //Create a new instance of the Car class
            //Set values in the properties for the object
            //Print the values of each property to the Console
            var myCar = new Car();

            myCar.Make = "LUCID";
            myCar.Model = "Air Touring";
            myCar.Year = 2023;

            Console.WriteLine($"Make: {myCar.Make} | Model: {myCar.Model} | Year: {myCar.Year}");
        }
    }
}
