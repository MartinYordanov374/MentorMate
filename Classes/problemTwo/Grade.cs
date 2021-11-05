class Grade
{
    # region FIELDS
        public double subjectGrade;
        public string subjectName;
    # endregion

    # region PROPERTIES
    public double SubjectGrade { get; set; }
    public string SubjectName { get; set; }

    # endregion

    # region CONSTRUCTOR
    public Grade(string subject, double grade)
    {
        this.subjectName = subject;
        this.subjectGrade = grade;
    }
    # endregion

    # region METHODS
    # endregion
}