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
        List<Grade> grades = new List<Grade>();
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
        public void addGrade(string Subject, Grade grade)
        {
            
            try
            {
                if(grade.SubjectGrade > 6)
                {
                    grade.SubjectGrade = 6;
                }
                grades.Add(grade);
            }

            catch(Exception)
            {
                Console.WriteLine("It appears that the grade you entered is invalid. Is it a number?");
            }

        }
        public void calculateAverageGrade(int classesAmount)
        {
            

            int mathGradesCount = grades.Where(c => c.subjectName == "Mathematics").Count();
            int physicsGradesCount = grades.Where(c => c.subjectName == "Physics").Count();
            int softwareGradesCount = grades.Where(c => c.subjectName == "Software").Count();
            int literatureGradesCount = grades.Where(c => c.subjectName == "Literature").Count();

            double mathGrade = 0;
            double physicsGrade = 0;
            double softwareGrade = 0;
            double literatureGrade = 0;

            var mathGrades = grades.Where(c => c.subjectName == "Mathematics").Select(item => item.subjectGrade).ToArray();
            var physicsGrades = grades.Where(c => c.subjectName == "Physics").Select(item => item.subjectGrade).ToArray();
            var softwareGrades = grades.Where(c => c.subjectName == "Software").Select(item => item.subjectGrade).ToArray();
            var literatureGrades = grades.Where(c => c.subjectName == "Literature").Select(item => item.subjectGrade).ToArray();

            foreach(double grade in mathGrades)
            {
                mathGrade += grade;
            }

            foreach(double grade in physicsGrades)
            {
                physicsGrade += grade;
            }

            foreach(double grade in softwareGrades)
            {
                softwareGrade += grade;
            }

            foreach(double grade in literatureGrades)
            {
                literatureGrade += grade;
            }
            
            mathGrade /= mathGradesCount;
            physicsGrade /= physicsGradesCount;
            softwareGrade /= softwareGradesCount;
            literatureGrade /= literatureGradesCount;

            double averageGradeTotal = (mathGrade + physicsGrade + softwareGrade + literatureGrade) / classesAmount;
            calculateFinalGrade(averageGradeTotal);
        }

        public void calculateFinalGrade(double averageGrade)
        {


            string isPassing = isStudentPassing(averageGrade) ? $"Student passed with a grade of {averageGrade}" : "Student failed to pass";

            Console.WriteLine(isPassing);
        }
    #endregion
    

}