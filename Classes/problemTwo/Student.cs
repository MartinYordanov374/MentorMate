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
    #endregion
}