using System;
using System.Windows.Forms;

namespace SR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StudentManager.InitializeData();
            UpdateRecordCount();
        }

        private void UpdateRecordCount()
        {
            labelRecordCount.Text = StudentManager.Students.Count.ToString();
        }

        private bool ValidateInput(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                errorMessage = "Фамилия не может быть пустой!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                errorMessage = "Имя не может быть пустым!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPatronymic.Text))
            {
                errorMessage = "Отчество не может быть пустым!";
                return false;
            }

            if (dateTimePickerBirthDate.Value >= DateTime.Now)
            {
                errorMessage = "Дата рождения не может быть позднее текущей даты!";
                return false;
            }

            if (comboBoxGender.SelectedIndex == -1)
            {
                errorMessage = "Выберите пол!";
                return false;
            }

            if (!int.TryParse(textBoxStudentCardNumber.Text, out int studentCardNumber) || studentCardNumber <= 0)
            {
                errorMessage = "Номер студенческого билета должен быть целым положительным числом!";
                return false;
            }

            if (comboBoxStudyBasis.SelectedIndex == -1)
            {
                errorMessage = "Выберите основу обучения!";
                return false;
            }

            if (!int.TryParse(textBoxDebtsCount.Text, out int debtsCount) || debtsCount < 0)
            {
                errorMessage = "Количество задолженностей должно быть целым неотрицательным числом!";
                return false;
            }

            return true;
        }

        private void ClearInputFields()
        {
            textBoxLastName.Clear();
            textBoxFirstName.Clear();
            textBoxPatronymic.Clear();
            dateTimePickerBirthDate.Value = DateTime.Now.AddYears(-20);
            comboBoxGender.SelectedIndex = -1;
            textBoxStudentCardNumber.Clear();
            comboBoxStudyBasis.SelectedIndex = -1;
            textBoxDebtsCount.Clear();
            textBoxNotes.Clear();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var student = new Student(
                textBoxLastName.Text.Trim(),
                textBoxFirstName.Text.Trim(),
                textBoxPatronymic.Text.Trim(),
                dateTimePickerBirthDate.Value,
                comboBoxGender.SelectedItem.ToString(),
                int.Parse(textBoxStudentCardNumber.Text),
                comboBoxStudyBasis.SelectedItem.ToString(),
                int.Parse(textBoxDebtsCount.Text),
                textBoxNotes.Text.Trim()
            );

            if (StudentManager.AddStudent(student, out errorMessage))
            {
                MessageBox.Show("Студент успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
                UpdateRecordCount();
            }
            else
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowAllStudents_Click(object sender, EventArgs e)
        {
            var students = StudentManager.GetStudentsInAlphabeticalOrder();
            ShowResultForm("Список группы (алфавитный порядок)", students, true);
        }

        private void buttonShowStudentsWithoutDebts_Click(object sender, EventArgs e)
        {
            var students = StudentManager.GetStudentsWithoutDebts();
            ShowResultForm("Студенты без задолженностей (сортировка по № студ. билета)", students, false);
        }

        private void ShowResultForm(string title, List<Student> students, bool allowEdit)
        {
            var resultForm = new ResultForm(title, students, allowEdit);
            resultForm.ShowDialog(this);
            UpdateRecordCount();
        }
    }
}
