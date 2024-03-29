﻿using System;
using System.Threading.Channels;

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
        public const double FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public string FromUnit;
        public string ToUnit;

        public double ToDistance;
        public double FromDistance;
        
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
            Console.WriteLine("4. Close");

            Console.WriteLine("Enter");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        return "miles";
                    case 2:
                        return "feet";
                    case 3:
                        return "metres";
                    case 4:
                        Close();
                        break;
                }
                if (choice <= 0 || choice > 4)
                {
                    Console.WriteLine("Invalid choice. Please enter 1 - 4. \n");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter numbers 1 - 4");
                }
                        
            return null;         
        }

        public double InputDistance(string prompt)
        {
            Console.WriteLine("You are converting " + FromUnit + " to " + ToUnit);
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
            else if (FromUnit == "miles" && ToUnit == "metres")
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == "feet" && ToUnit == "metres")
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
            else if (FromUnit == "metres" && ToUnit == "feet")
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
            else if (FromUnit == "metres" && ToUnit == "miles")
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == ToUnit)
            {
                ToDistance = FromDistance;
            }
        }


        private void Print() 
        {
            OutputHeading();
            Console.WriteLine(FromDistance + " " + FromUnit + " is " + ToDistance + " " + ToUnit);
            Close();
        }

        private void Close()
        {
            Console.WriteLine("Close application? \n" + "1.Yes \n" + "2.No");
            int shutdown;
            shutdown = Convert.ToInt32(Console.ReadLine());
            switch (shutdown)
            {
                case 1:
                    System.Environment.Exit(0);
                    break;
                case 2:
                    Run();
                    break;
            }
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
