using System;
class Grade
{
    # region FIELDS
        public double subjectGrade;
        public Enum subjectName;
    # endregion

    # region PROPERTIES
    public double SubjectGrade { get; set; }
    public Enum SubjectName { get; set; }

    # endregion

    # region CONSTRUCTOR
    public Grade(Enum subject, double grade)
    {
        this.subjectName = subject;
        this.subjectGrade = grade;
    }
    # endregion

    # region METHODS
    # endregion
}