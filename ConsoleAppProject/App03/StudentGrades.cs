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
                return Grades.C;
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

        public void CalculateGradeProfile()
        {
            for (int i = 0; i < CalculateGradeProfile().Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                CalculateGradeProfile[(int)grade]++;
            }
        }

        public void DisplayGradeProfile()
        {
            int[] gradeCounts = new int[5];
            int highest = 0;
            int lowest = 100;

            foreach (int mark in Marks)
            {
                if (mark >= MinA)
                {
                    gradeCounts[4]++;
                    if (mark > highest) highest = mark;
                    if (mark < lowest) lowest = mark;
                }
                else if (mark >= MinB)
                {
                    gradeCounts[3]++;
                    if (mark < lowest) lowest= mark;
                }
                else if (mark >= MinC)
                {
                    gradeCounts[2]++;
                    if (mark < lowest) lowest = mark;
                }
                else if (mark >= MinD)
                {
                    gradeCounts[1]++;
                    if (mark < lowest) lowest = mark;
                }
                else
                {
                    gradeCounts[0]++;
                    if (mark < lowest) lowest = mark;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Grade Profile:");
            int total = gradeCounts.Sum();
            Console.WriteLine($"A: {gradeCounts[4]} {(double)gradeCounts[4] / total:P}");
            Console.WriteLine($"B: {gradeCounts[3]} {(double)gradeCounts[3] / total:P}");
            Console.WriteLine($"C: {gradeCounts[2]} {(double)gradeCounts[2] / total:P}");
            Console.WriteLine($"D: {gradeCounts[1]} {(double)gradeCounts[1] / total:P}");
            Console.WriteLine($"Fail: {gradeCounts[0]} {(double)gradeCounts[0] / total:P}");
            Console.WriteLine("Highest grade:");
            for (int i = 0; i < Students.Length; i++)
            {
                if (Marks[i] == highest)
                {
                    double percentage = (double)EnterMarks[i] / Max * 100;
                    Console.WriteLine($"{Students[i]} got {Marks[i]} marks and the percentage {percentage:F2}%");
                }
            }
            Console.WriteLine("Lowest grade:");
            for (int i = 0; i < Students.Length; i++)
            {
                if (EnterMarks[i] == lowest)
                {
                    double percentage = (double)Marks[i] / Max * 100;
                    Console.WriteLine($"{Students[i]} got {Marks[i]} marks and the percentage {percentage:F2}%");
                }
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            OpeningMenu();
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