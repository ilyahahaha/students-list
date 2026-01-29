namespace SR2
{
    public class Student(string lastName, string firstName, string patronymic,
                  DateTime birthDate, string gender, int studentCardNumber,
                  string studyBasis, int debtsCount, string notes)
    {
        public string LastName { get; set; } = lastName;
        public string FirstName { get; set; } = firstName;
        public string Patronymic { get; set; } = patronymic;
        public DateTime BirthDate { get; set; } = birthDate;
        public string Gender { get; set; } = gender;
        public int StudentCardNumber { get; set; } = studentCardNumber;
        public string StudyBasis { get; set; } = studyBasis;
        public int DebtsCount { get; set; } = debtsCount;
        public string Notes { get; set; } = notes;

        public string FullName => $"{LastName} {FirstName} {Patronymic}";
    }
}