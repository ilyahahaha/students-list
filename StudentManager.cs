namespace SR2
{
    public static class StudentManager
    {
        private static List<Student> _students = [];
        public static List<Student> Students => _students;

        public static void InitializeData()
        {
            _students =
            [
                new Student("Иванов", "Иван", "Иванович", new DateTime(2001, 10, 10), "мужской", 1111, "бюджетная", 0, "староста"),
                new Student("Петров", "Петр", "Петрович", new DateTime(2002, 5, 15), "мужской", 1112, "платная", 2, ""),
                new Student("Сидорова", "Анна", "Сергеевна", new DateTime(2001, 8, 20), "женский", 1113, "бюджетная", 0, "отличница"),
                new Student("Козлов", "Михаил", "Андреевич", new DateTime(2002, 3, 12), "мужской", 1114, "платная", 1, ""),
                new Student("Смирнова", "Елена", "Викторовна", new DateTime(2001, 12, 5), "женский", 1115, "бюджетная", 0, ""),
                new Student("Новиков", "Алексей", "Дмитриевич", new DateTime(2002, 7, 25), "мужской", 1116, "платная", 0, ""),
                new Student("Васильева", "Ольга", "Николаевна", new DateTime(2001, 4, 18), "женский", 1117, "бюджетная", 3, ""),
                new Student("Морозов", "Дмитрий", "Владимирович", new DateTime(2002, 9, 30), "мужской", 1118, "платная", 0, "спортсмен"),
                new Student("Павлова", "Мария", "Александровна", new DateTime(2001, 6, 14), "женский", 1119, "бюджетная", 0, ""),
                new Student("Федоров", "Сергей", "Игоревич", new DateTime(2002, 11, 22), "мужской", 1120, "платная", 1, "")
            ];
        }

        public static bool AddStudent(Student student, out string errorMessage)
        {
            if (IsStudentCardNumberExists(student.StudentCardNumber))
            {
                errorMessage = "Студент с таким номером студенческого билета уже существует!";
                return false;
            }

            _students.Add(student);
            errorMessage = string.Empty;
            return true;
        }

        public static bool IsStudentCardNumberExists(int studentCardNumber)
        {
            return _students.Any(s => s.StudentCardNumber == studentCardNumber);
        }

        public static List<Student> GetStudentsInAlphabeticalOrder()
        {
            return [.. _students.OrderBy(s => s.LastName)
                          .ThenBy(s => s.FirstName)
                          .ThenBy(s => s.Patronymic)];
        }

        public static List<Student> GetStudentsWithoutDebts()
        {
            return [.. _students.Where(s => s.DebtsCount == 0).OrderBy(s => s.StudentCardNumber)];
        }

        public static void RemoveStudent(Student student)
        {
            _students.Remove(student);
        }

        public static void UpdateStudent(Student studentToUpdate, string lastName, string firstName, 
                                        string patronymic, DateTime birthDate, string gender, 
                                        string studyBasis, int debtsCount, string notes)
        {
            studentToUpdate.LastName = lastName;
            studentToUpdate.FirstName = firstName;
            studentToUpdate.Patronymic = patronymic;
            studentToUpdate.BirthDate = birthDate;
            studentToUpdate.Gender = gender;
            studentToUpdate.StudyBasis = studyBasis;
            studentToUpdate.DebtsCount = debtsCount;
            studentToUpdate.Notes = notes;
        }
    }
}