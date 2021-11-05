using System;
using System.Collections.Generic;
using System.Linq;
namespace problemTwo
{
    class Program
    {
        public enum subjects
        {
            Mathematics = 1,
            Physics = 2,
            Software = 3,
            Literature = 4 
        }
        static void Main(string[] args)
        {
            Student John = new Student("John", "11e");

            int subjectRequiredGrades = 4;
            int classesAmount = 4;

            for(int i = 1; i <= subjectRequiredGrades; i++)
            {
                subjects currClass = subjects.Mathematics;

                switch(i)
                {

                    case 1:
                    {
                        currClass = subjects.Mathematics;
                        break;
                    }
                    
                    case 2:
                    {
                        currClass = subjects.Physics;
                        break;
                    }

                    case 3:
                    {
                        currClass = subjects.Software;
                        break;
                    }

                    case 4:
                    {
                        currClass = subjects.Literature;
                        break;
                    }

                }

                Console.WriteLine($"Enter {subjectRequiredGrades} grades for {currClass} class: ");

                for(int j = 1; j <= classesAmount; j++)
                {
                    Console.WriteLine($"Enter grade {j}: ");

                    double grade = double.Parse(Console.ReadLine());
                    string convertedSubject = currClass.ToString();
                    John.addGrade(convertedSubject, grade);

                }

                John.calculateAverageGrade();

            }

            John.calculateFinalGrade(subjectRequiredGrades);

        }
    }
}
