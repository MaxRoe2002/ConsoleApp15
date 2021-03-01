<<<<<<< HEAD
﻿using System;
using System.Runtime;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
=======
﻿using ConsoleAppProject.App01;
using System;
>>>>>>> 41fdf28bbf222d0aaa5a0bc766c1f1b39ee243ea

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Max Roe 11/2/2021
    /// </summary>
    public static class Program
    {
        public static DistanceConverter DistanceConverter
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

            DistanceConverter converter = new DistanceConverter();

<<<<<<< HEAD
            BMI calculator = new BMI();
            calculator.PrintHeading();
            calculator.OutputUnits();
            calculator.GetUnit();
            calculator.GetWeight();
            calculator.GetHeight();
            calculator.CalculateBMI();
            calculator.OutputResult();

            //DistanceConverter converter = new DistanceConverter();

            //converter.ConvertDistance();
=======
            converter.ConvertDistance();
>>>>>>> 41fdf28bbf222d0aaa5a0bc766c1f1b39ee243ea
        }
    }
}
