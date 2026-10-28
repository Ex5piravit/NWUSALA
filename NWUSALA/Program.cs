using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static string studentName;
        static string studentNumber;
        static string[] modules = new string[6];
        static double[] marks = new double[6];
        static int passedModules = 0;
        static int faildModules = 0;
        static double average = 0;
        static void Main(string[] args)
        {
            CaptureStudentDetails();
            CaptureMarks();
            CalculateResults();
            DisplayResults();
            Console.ReadKey();
        }
        static void CaptureStudentDetails()
        {
            Console.WriteLine("enter student Name");
            studentName = Console.ReadLine();
            Console.WriteLine("Enter student number");
            studentNumber = Console.ReadLine();
        }
        static void CaptureMarks()
        {
            for (int i = 0; i <= modules.Length; i++)
            {
                Console.WriteLine($"\n Enter Module{i + 1}Name:");
                modules[i] = Console.ReadLine();
                Console.WriteLine($"\n Enter Module Marks{i + 1}Marks:");
                marks[i] = Convert.ToDouble(Console.ReadLine());
                while (marks[i] < 0 || marks[i] > 100)
                {
                    Console.WriteLine("Invalid mark; Please enter a mark between 0 and 100");
                    marks[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        static void CalculateResults()
        {
            double totalmarks = 0.0;
            for (int i = 0; i < marks.Length; i++)
            {
                totalmarks += marks[i];
                if (marks[i] >= 50)
                {
                    passedModules++;

                }
                else
                {
                    faildModules++;
                }
            }
            average = totalmarks / marks.Length;
        }
        static string DetermineGrade(double marks)
        {
            if (marks >= 75 && marks <= 100)
            {
                return "excellent prograss";
            }
            else if (marks >= 50 && marks < 75)
            {
                return "pass";
            }
            else
            {
                return "faild";
            }
        }
        static string DetermineConsequenc()
        {
            if (faildModules == 0)
            {
                return "Congradulations!! You have passed all modules";
            }
            else if (faildModules <= 2)
            {
                return " you hvae faild some Modules.letter of warning.";
            }
            else
            {
                return " your funding is revoked";
            }
        }
        static string DetermineVerdict()
        {
            if (average >= 75 && average <= 100)
            {
                return "Distinction";
            }
            else if (average >= 50 && average < 75)
            {
                return "pass";
            }
            else
            {
                return "fail";
            }
        }
        static void DisplayResults()
        {
            Console.WriteLine($"\nStudent Name:{studentName}");
            Console.WriteLine($"\nStudent Number:{studentNumber}");
            Console.WriteLine("\nModule Results");
            for(int i = 0;i < modules.Length; i++)
            {
                Console.WriteLine($"{modules[i]}: {marks[i]}- {DetermineGrade(marks[i])}");
            }
            Console.WriteLine($"\n Average Mark:{average}");
            Console.WriteLine($"\n VErdict:{DetermineVerdict()}");
            Console.WriteLine($"passed Modules: {passedModules}");
            Console.WriteLine($"faild Modules: {faildModules}");
            Console.WriteLine($"COnsequences:{DetermineConsequenc()}");
            if(average >= 75 && average <= 100)
            {
                Console.WriteLine("Congradulations! You have passed with distinction.");
            }
            else if (average >= 50 && average < 75)
            {
                Console.WriteLine("You have passed. keep up the good work!");
            }
            else
            {
                Console.WriteLine("you have faild. please seek academic support.");
            }
        }
    }
}