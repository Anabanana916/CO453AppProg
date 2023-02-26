using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMICalculator
    {
        public const int FEET_IN_MILES = 5280;

        public const double KG_IN_STONE = 0.15747;

        public const double FEET_IN_METRES = 3.28084;

        string WeightUnit;
        string HeightUnit;

        double Height;
        double Weight;
        double BMI;

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        /// 
        public void Run()
        {
            //step 1 - Input

            Console.Write("Please select WEIGHT: \n");
            WeightUnit = WeightMenu();
            Console.WriteLine("Please select HEIGHT: \n");
            HeightUnit = HeightMenu();

            Weight = InputDistance(WeightUnit);

            //WeightUnit= "Miles"
            //HeightUnit = "feet"

            // step 2 - conversion process
            BMICalc();

            // step 3
            Print();
        }


        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        /// 

        public string HeightMenu()
        {
            Console.WriteLine("1. Metres");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Close");

            Console.WriteLine("Enter");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                return "metres";
            }
            else if (choice == 2)
            {
                return "feet";
            }
            else if (choice == 3)
            {
                Close();
            }
            if (choice <= 0 || choice > 3)
            {
                Console.WriteLine("Invalid choice. Please enter 1 - 3. \n");
            }
            return null;
        }

        public string WeightMenu()
        {
            Console.WriteLine("1. KG");
            Console.WriteLine("2. Stone");
            Console.WriteLine("Enter");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                return "KG";
            }
            else if (choice == 2)
            {
                return "stone";
            }
            if (choice <= 0 || choice > 2)
            {
                Console.WriteLine("Invalid choice. Please enter 1 - 2. \n");
            }
            return null;
        }
        public double InputDistance(string prompt)
        {
            Console.WriteLine("Please enter the number of " + prompt);
            return Convert.ToDouble(Console.ReadLine());
        }

        public void BMICalc()
        {
            ///<author>switch (BMI)
            ///{
            ///    case WeightUnit == "KG" && HeightUnit =="metres"
            ///        BMI = Weight / Height;
            ///        break;
            ///    case WeightUnit == "Stone" && HeightUnit == "feet"
            ///        BMI = Weight / Height;
            ///        break;
            ///    case WeightUnit == "KG" && HeightUnit == "feet"
            ///        BMI = Weight / Height;
            ///        break;
            ///    case WeightUnit == "Stone" && HeightUnit == "metres"
            ///        BMI = Weight / Height;
            ///        break;
            ///}
            ///</author>
            if (WeightUnit == "KG" && HeightUnit == "metres")
            {
                BMI = Weight / (Height*Height);
            }
            else if (WeightUnit == "stone" && HeightUnit == "feet")
            {
                BMI = Weight / (Height*Height);
            }
            else if (WeightUnit == "KG" && HeightUnit == "feet")
            {
                BMI = Weight / (Height*Height);
            }
            else if (WeightUnit == "stone" && HeightUnit == "metres")
            {
                BMI = Weight / (Height*Height);
            }
        }

        private void Print()
        {
            OutputHeading();
            Console.WriteLine(@"WHO Weight Status | BMI (kg/m^2)
                              Underweight | < 18.50
                              Normal | 18.5 - 24.9
                              Overweight | 25.0 - 29.9
                              Obese Class I | 30.0 - 34.9
                              Obese Class II | 35.0 - 39.9
                              Obese Class III | >= 40.0");
            if (BMI < 18.5)
            {
                Console.WriteLine("Your BMI is: " + BMI + ". You are underweight.");
            }
            else if (BMI >= 18.5 && BMI <= 24.99)
            {
                Console.WriteLine("Your BMI is: " + BMI + ". You are normal weight.");
            }
            else if (BMI >= 25.0 && BMI <= 29.99)
            {
                Console.WriteLine("Your BMI is: " + BMI + ". You are overweight.");
            }
            else if (BMI >= 30.0 && BMI <= 34.99)
            {
                Console.WriteLine("Your BMI is: " + BMI + ". You are obese class one.");
            }
            else if (BMI >= 35.0 && BMI <= 39.99)
            {
                Console.WriteLine("Your BMI is: " + BMI + ". You are obese class two.");
            }
            else if (BMI >= 40.0)
            {
                Console.WriteLine("Your BMI is: " + BMI + ". You are obese class three.");
            }
            Close();
        }

        private void Close()
        {
            Console.WriteLine("Close application? \n" + "1.Yes \n" + "2.No");
            int shutdown;
            shutdown = Convert.ToInt32(Console.ReadLine());
            if (shutdown == 1)
            {
                System.Environment.Exit(0);
            }
            else if (shutdown == 2)
            {
                Run();
            }
        }


        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" ---------------------------- ");
            Console.WriteLine("Distance Convertion Calculator");
            Console.WriteLine("         By Ana Elderton        ");
            Console.WriteLine(" ------------------------------ ");
            Console.WriteLine();
        }
    }
}

   
