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

            Enum mathematicsClass = subjects.Mathematics;

            Enum physicsClass = subjects.Physics;

            Enum softwareClass = subjects.Software;

            Enum literatureClass = subjects.Literature;
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