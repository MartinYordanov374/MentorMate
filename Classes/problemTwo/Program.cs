using System;
using System.Collections.Generic;
using System.Linq;
namespace problemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student John = new Student("John", "11e");

            int subjectRequiredGrades = 4;
            int classesAmount = 4;

            List<double> grades = new List<double>();
            List<double> averageGrades = new List<double>();

            for(int i = 1; i <= subjectRequiredGrades; i++)
            {
                string currClass = string.Empty;

                switch(i)
                {

                    case 1:
                    {
                        currClass = "Mathematics";
                        break;
                    }
                    
                    case 2:
                    {
                        currClass = "Physics";
                        break;
                    }

                    case 3:
                    {
                        currClass = "Software";
                        break;
                    }

                    case 4:
                    {
                        currClass = "Literature";
                        break;
                    }

                }

                Console.WriteLine($"Enter {subjectRequiredGrades} grades for {currClass} class: ");

                for(int j = 1; j <= classesAmount; j++)
                {
                    Console.WriteLine($"Enter grade {j}: ");

                    try
                    {
                        double grade = double.Parse(Console.ReadLine());

                        if(grade > 6)
                        {
                            grade = 6;
                        }

                        grades.Add(grade);
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("It appears that the grade you entered is invalid. Is it a number?");
                    }

                }

                double gradesSum = grades.Aggregate((item, itemTWo) => {
                   return item + itemTWo;
                });

                double average = gradesSum / grades.Count();

                averageGrades.Add(average);

                Console.WriteLine($"Average -> {average}");

                grades.Clear();

            }

            double finalGradesSum = averageGrades.Aggregate((itemOne, itemTwo) => {
                return itemOne + itemTwo;
            });

            double finalGrade = finalGradesSum / subjectRequiredGrades;

            string isPassing = John.isStudentPassing(finalGrade) ? $"Student passed with a grade of {finalGrade}" : "Student failed to pass";

            Console.WriteLine(isPassing);

        }
    }
}
