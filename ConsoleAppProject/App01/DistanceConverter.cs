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
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        string FromUnit;
        string ToUnit;

        double ToDistance;
        double FromDistance;
        
        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        /// 
        public void Run()
        {
            //step 1 - Input

            Console.Write("Enter the FROM unit: \n");
            FromUnit = UnitMenu();
            Console.WriteLine("Enter the TO unit: \n");
            ToUnit = UnitMenu();

            FromDistance = InputDistance(FromUnit);

            //FromUnit= "Miles"
            //ToUnit = "feet"

            // step 2 - conversion process
            ConvertDistance();

            // step 3
            Print();
        }
        

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        /// 

        public string UnitMenu()
        {
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Metres");

            Console.WriteLine("Enter");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                return "miles";
            }
            else if (choice == "2")
            {
                return "feet";
            }
            else if (choice == "3")
            {
                return "metres";
            }
                return null;
        }

        public double InputDistance(string prompt)
        {
            Console.WriteLine("Please enter the number of " + prompt);
            return Convert.ToDouble(Console.ReadLine());
        }

        public void ConvertDistance()
        {
            if (FromUnit == "miles" && ToUnit == "feet")
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == "feet" && ToUnit == "miles")
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
         }

        ///private void CalculateMetres()
        ///{
        ///    metres = miles * METRES_IN_MILES;
        ///}

        private void Print() 
        {
            OutputHeading();
            Console.WriteLine(FromDistance + " " + FromUnit + " is " + ToDistance + " " + ToUnit);
        }

        private void OutputHeading()
        { 
            Console.WriteLine();
            Console.WriteLine( " ---------------------------- " );
            Console.WriteLine( "Distance Convertion Calculator" );
            Console.WriteLine("         By Ana Elderton        ");
            Console.WriteLine(" ------------------------------ ");
            Console.WriteLine();
        }
    }
}
