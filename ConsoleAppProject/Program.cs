using System;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Max Roe 15/03/2021
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();

        private static BMI calculator = new BMI();

        private static StudentGrades grades = new StudentGrades();

        private static NetworkApp news = new NetworkApp();

        public static BMI BMI
        {
            get => default;
        }

        public static StudentGrades StudentGrades
        {
            get => default;
            set
            {
            }
        }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();

            string[] choices = { "Distance Converter", "BMI Calculator", "Student Marks", "Social Network"};


            int choiceNo = ConsoleHelper.MakeChoice(choices);

            if (choiceNo == 1)
            {
                converter.ConvertDistance();
            }
            else if (choiceNo == 2)
            {
                calculator.PrintHeading();
                calculator.OutputUnits();
                calculator.GetUnit();
                calculator.GetWeight();
                calculator.GetHeight();
                calculator.CalculateBMI();
                calculator.OutputResult();
            }
            else if (choiceNo == 3)
            {
                grades.DisplayMenu();
            }
            else if (choiceNo ==4)
            {
                news.DisplayMenu();
            }
            else Console.WriteLine("Invalid Choice !");
        }
    }
}