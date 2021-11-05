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

            string mathematicsClass = subjects.Mathematics.ToString();

            string physicsClass = subjects.Physics.ToString();

            string softwareClass = subjects.Software.ToString();

            string literatureClass = subjects.Literature.ToString();

            int subjectRequiredGrades = Enum.GetNames(typeof(subjects)).Length;

            Grade mathGrade = new Grade(mathematicsClass, 6);
            Grade physicsGrade = new Grade(physicsClass, 5);
            Grade softwareGrade = new Grade(softwareClass, 6);

            Grade literatureGrade = new Grade(literatureClass, 6);

            John.AddGrade(mathematicsClass, mathGrade);    
            John.AddGrade(physicsClass, physicsGrade);    
            John.AddGrade(softwareClass, softwareGrade);    
            John.AddGrade(literatureClass, literatureGrade);   

            John.CalculateAverageGrade(subjectRequiredGrades);
            
        }
    }
}
