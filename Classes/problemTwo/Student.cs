using System;
using System.Collections.Generic;
using System.Linq;
class Student
{


    #region FIELDS

        private string _name;
        private string _studentClass;

    #endregion

    #region PROPERTIES  

        public int Name { get; set; }  
        public int StudentClass { get; set; }

    #endregion

    #region CONSTRUCTOR
        public Student(string studentName, string studentClass)
        {
            this._name = studentName;
            this._studentClass = studentName;
        }

    #endregion

    #region lists
        List<double> grades = new List<double>();
        List<double> averageGrades = new List<double>();
    #endregion

    #region METHODS
        public bool isStudentPassing(double averageGrade)
        {
            if(averageGrade > 2.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void addGrade(string Subject, double grade)
        {
            
            try
            {
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
        public void calculateAverageGrade()
        {
            double gradesSum = grades.Aggregate((item, itemTWo) => {
               return item + itemTWo;
            });

            double average = gradesSum / grades.Count();

            averageGrades.Add(average);

            grades.Clear();
        }

        public void calculateFinalGrade(int subjectRequiredGrades)
        {
             double finalGradesSum = averageGrades.Aggregate((itemOne, itemTwo) => {
                return itemOne + itemTwo;
            });

            double finalGrade = finalGradesSum / subjectRequiredGrades;

            string isPassing = isStudentPassing(finalGrade) ? $"Student passed with a grade of {finalGrade}" : "Student failed to pass";

            Console.WriteLine(isPassing);
        }
    #endregion
    

}