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

            John.addGrade(mathematicsClass, 5);    
            John.addGrade(mathematicsClass, 6);    
            John.addGrade(mathematicsClass, 6);    
            John.addGrade(mathematicsClass, 6);   

            John.calculateAverageGrade();

            John.addGrade(physicsClass, 6);
            John.addGrade(physicsClass, 5);
            John.addGrade(physicsClass, 6);
            John.addGrade(physicsClass, 6);  
            
            John.calculateAverageGrade();

            John.addGrade(softwareClass, 6);  
            John.addGrade(softwareClass, 5);  
            John.addGrade(softwareClass, 6); 

            John.calculateAverageGrade();

            John.addGrade(literatureClass, 4); 
            John.addGrade(literatureClass, 6); 
            John.addGrade(literatureClass, 6); 

            John.calculateAverageGrade();

            John.calculateFinalGrade(subjectRequiredGrades);

        }
    }
}
