using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        // Constructors
        public const int fail = 0;
        public const int MinD = 40;
        public const int MinC = 50;
        public const int MinB = 60;
        public const int MinA = 70;

        // Properties
        public string[] Students { get; set; }
        public int[] Grades { get; set; }

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine("                     Ana Elderton                 ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
        }

        public void OpeningMenu()
        {
            OutputHeading();
            string[] options = new string[]
            {
                "Enter Marks",
                "Display Grades",
                "Display Stats",
                "Display Grade Profile",
                "Exit"
            };

            int choice = ConsoleHelper.SelectChoice(choice);
            switch (choice)
            {
                case 1:
                    EnterMarks();
                    break;
                case 2:
                    DisplayGrades();
                    break;
                case 3:
                    DisplayStats();
                    break;
                case 4:
                    DisplayGradeProfile();
                    break;
                case 5:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please enter between options 1-5)");
                    break;
            }
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

    }
}