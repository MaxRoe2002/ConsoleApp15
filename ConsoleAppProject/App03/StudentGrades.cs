using System;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Application for converting marks into grades and calculating
    /// the mean, maximum and minimum mark that were entered.
    /// </summary>
    public class StudentGrades
    {
        // Constants (Grade Boundaries)

        public const int LowestMark = 0;

        public const int LowestGradeD = 40;

        public const int LowestGradeC = 50;

        public const int LowestGradeB = 60;

        public const int LowestGradeA = 70;

        public const int HighestMark = 100;

        // Properties
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        /// <summary>
        /// Used by class diagram
        /// </summary>
        public ConsoleHelper ConsoleHelper
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Used by class diagram
        /// </summary>
        public Grades Grades
        {
            get => default;
            set
            {
            }
        }

        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("Student Marks");

            InputMarks();
            OutputMarks();
            CalculateStats();
            CalculateGradeProfile();
            OutputStats();

        }

        /// <summary>
        /// Input a mark between 0-100 for each
        /// student and store in the marks array.
        /// </summary>
        public void InputMarks()
        {
            int Mark;

            Marks = new int[10];
            Students = new string[]
            {
                "Bradley","Max", "Luke",
                "Daniel", "Robbie","Thomas",
                "Ben", "Lewis", "Aaron",
                "Leo"
            };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

            for (int i = 0; i < Students.Length; i++)
            {
                Mark = (int)ConsoleHelper.InputNumber("Please enter mark for the student(s) " + Students[i] + " " + (i + 1) + ": ");

                Marks[i] = Mark;
            }

            Console.WriteLine("\nYou have successfully entered a mark for the student(s)\n");
        }

        /// <summary>
        /// List all the students and display their
        /// name and current mark.
        /// </summary>
        public void OutputMarks()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($" {Students[i]} {Marks[i]}");
            }
        }

        /// <summary>
        /// Convert a student mark ti a grade
        /// from F(fail) to A(Pass).
        /// </summary>
        public Grades ConvertToGrade(int Marks)
        {
            if (Marks >= 0 && Marks < LowestGradeD)
            {
                return Grades.F;
            }
            else if (Marks >= LowestGradeD && Marks < LowestGradeC)
            {
                return Grades.D;
            }
            else if (Marks >= LowestGradeC && Marks < LowestGradeB)
            {
                return Grades.C;
            }
            else if (Marks >= LowestGradeB && Marks < LowestGradeA)
            {
                return Grades.B;
            }
            else if (Marks >= LowestGradeA && Marks <= HighestMark)
            {
                return Grades.A;
            }

            return Grades.F;

        }

        /// <summary>
        /// Calculate and display the minimum, maximum
        /// and mean mark for all the students.
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;

            Minimum = Marks[0];
            Maximum = Marks[0];

            foreach (int mark in Marks)
            {
                total = total + mark;
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
            }

            Mean = total / Marks.Length;
        }

        /// <summary>
        /// Outputs the mean, minimum and maximum marks
        /// </summary>
        public void OutputStats()
        {
            OutputMean();
            OutputMinimum();
            OutputMaximum();
        }


        public void OutputMean()
        {
            CalculateStats();
            Console.Write(" \nThe mean mark is " + $"{Mean}");
        }

        public void OutputMinimum()
        {
            CalculateStats();
            Console.Write(" \nThe lowest mark is " + $"{Minimum}");
        }

        public void OutputMaximum()
        {
            CalculateStats();
            Console.Write(" \nThe highest mark is" + $"{Maximum}");
        }

        /// <summary>
        /// Calculates the the students grades.
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
            OutputGradeProfile();
        }

        /// <summary>
        /// Outputs the students grades and displays them. 
        /// </summary>
        public void OutputGradeProfile()
        {
            Grades grade = Grades.F;

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                grade++;
                Console.WriteLine($"\nGrade {grade} {percentage}% Count {count}");
            }
            Console.WriteLine();
        }
    }

}
