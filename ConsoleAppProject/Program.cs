using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
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
            PostUI social = new PostUI();

            Console.WriteLine(@"Please select application:
            1. Distance Converter
            2. BMI Calculator
            3. Student Grades
            4. Social Space");
            int selection;
            selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    converter.Run();
                    break;
                case 2:
                    body.Run();
                    break;
                case 3:
                    grades.Run();
                    break;
                case 4:
                    social.Run();
                    break;
            }
            if (selection < 1 || selection > 4)
            {
                Console.WriteLine("Invalid selection, please enter 1 or 4");
                Program.Main(args);
                Console.WriteLine(@"Please select application:
                1. Distance Converter
                2. BMI Calculator
                3. Grade Calculator
                4. Social Space");
            }
            
        }
    }
}
