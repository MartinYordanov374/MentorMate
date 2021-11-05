using System;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Student definetlyNotMartin = new Student("well, definetly not Martin", "probably 11");
            definetlyNotMartin.showStudentInfo();
        }
    }
    class Student
    {
        # region Fields
        private string _studentName = string.Empty;
        private string _studentClass = string.Empty;
        
        # endregion
    
        # region Properties
        public int StudentName { get; }
        public int StudentClass { get; }

        # endregion

        # region Constructor
        public Student(string studentName, string studentClass)
        {
            this._studentName = studentName;
            this._studentClass = studentClass;

            if(this._studentName.Length == 0 || this._studentClass.Length == 0)
            {
                throw new Exception("Invalid arguments provided. Please fix the arguments you've passed to the constructor.");
            }
        }
        # endregion
    
        # region publicMethods
        public void showStudentInfo()
        {
            System.Console.WriteLine($"Student's name is {this._studentName} and the class they attend is {this._studentClass}");
        }
        # endregion
    }
}
