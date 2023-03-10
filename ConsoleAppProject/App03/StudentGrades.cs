using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
                    Close();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please enter between options 1-5)");
                    break;
            }
        }

        public StudentGrades()
        {
            Students = new string[]
            {
                "Sharon","Samera","James","Michael", "Jane",
                "Luna","Jaina","Lucas","Aaron","Sean"
            };
            GradeProfile = new int[(int)Grades.AsMemory + 1];
            Marks = new int[Students.Length];
        }

        public void EnterMarks()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                bool validInput = false;
                int mark = 0;

                while (!validInput)
                {
                    Console.Write($"Enter mark for {Students[i]}: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out mark))
                    {
                        Console.WriteLine("Error! Please enter a mark between 0 and 100.");
                    }
                    else if (mark < 0 || mark > 100)
                    {
                        Console.WriteLine("Error! Please enter a number between 0 and 100.");
                    }
                    else
                    {
                        validInput = true;
                    }
                }

                EnterMarks[i] = mark;
            }
            Console.WriteLine("Marks complete.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            OpeningMenu();
        }

        public void DisplayGrades()
        {
            Console.WriteLine("Number".PadRight(5) + "Name".PadRight(5) + "Mark".PadRight(8) + "Grade");
            Console.WriteLine("-------------------------------------------------------------");
            int students = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                int mark = Marks[i];
                Grades grade = ConvertToGrade(mark);
                string studentNumber = (i + 1).ToString("D2");
                Console.Write($"{studentNumber}.".PadRight(5));
                Console.Write($"{Students[i]}".PadRight(5));
                Console.Write($"{mark}".PadRight(5));
                Console.WriteLine($"{grade}");
                students++;
            }
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"Total students: {students}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            OpeningMenu();
        }

        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < MinD)
            {
                return Grades.Fail;
            }
            else if (mark < MinC)
            {
                return Grades.D;
            }
            else if (mark < MinB)
            {
                return Grade.C;
            }
            else if (mark < MinA)
            {
                return Grades.B;
            }
            else
            {
                return Grades.A;
            }
        }

        public void DisplayStats()
        {
            CalculateStats();
            double average = Avergage;
            Console.WriteLine($"Class Average: {average.ToString("Fail")}");

            int min = Minimum;
            Console.WriteLine($"Lowest Mark: {min}");

            int max = Maximum;
            Console.WriteLine($"Maximum Mark: {max}");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            OpeningMenu();
        }

        public void CalculateStats()
        {
            Min = Marks[0];
            Max = Marks[0];

            double total = 0;
            foreach (int mark in Marks)
            {
                if (mark > Max) Max = mark;
                if (mark < Min) Min = mark;
            }

            Mean = total / Marks.Length;
        }

        public

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