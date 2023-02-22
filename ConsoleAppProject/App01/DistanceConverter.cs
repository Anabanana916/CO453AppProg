using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Ana version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;

        private double feet;
        
        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles: ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void OutputFeet() 
        {
            OutputHeading();
            Console.WriteLine(miles + " miles is " + feet + " feet|");
        }

        private void OutputHeading()
        { 
            Console.WriteLine();
            Console.WriteLine(" ---------------------------- ");
            Console.WriteLine("     Conver Miles to Feet     ");
            Console.WriteLine("        By Ana Elderton       ");
            Console.WriteLine(" ---------------------------- ");
            Console.WriteLine();
        }
    }
}
