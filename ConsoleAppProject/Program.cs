using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Ana Elderton 21/02/2023
    /// </summary>
    public static class Program
    {

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine("                     Ana Elderton                 ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            DistanceConverter converter = new DistanceConverter();
            BMICalculator body = new BMICalculator();
            StudentGrades grades = new StudentGrades();

            Console.WriteLine(@"Please select application:
            1. Distance Converter
            2. BMI Calculator");
            int selection;
            selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    converter.Run();
                case 2:
                    body.Run();
                case 3:
                    grades.Run();
            }

            if (selection == 1)
            {
                converter.Run();
            }
            else if (selection == 2)
            {
                body.Run();
            }
            else
            {
                Console.WriteLine("Invalid selection, please enter 1 or 2");
                Program.Main(args);
                Console.WriteLine(@"Please select application:
                1. Distance Converter
                2. BMI Calculator");
            }
            
        }
    }
}
