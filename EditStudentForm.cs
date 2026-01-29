namespace SR2
{
    public partial class EditStudentForm : Form
    {
        private Student originalStudent;

        public EditStudentForm(Student student)
        {
            InitializeComponent();
            originalStudent = student;
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            textBoxLastName.Text = originalStudent.LastName;
            textBoxFirstName.Text = originalStudent.FirstName;
            textBoxPatronymic.Text = originalStudent.Patronymic;
            dateTimePickerBirthDate.Value = originalStudent.BirthDate;
            comboBoxGender.SelectedItem = originalStudent.Gender;
            textBoxStudentCardNumber.Text = originalStudent.StudentCardNumber.ToString();
            textBoxStudentCardNumber.Enabled = false; // Номер студенческого билета не изменяется
            comboBoxStudyBasis.SelectedItem = originalStudent.StudyBasis;
            textBoxDebtsCount.Text = originalStudent.DebtsCount.ToString();
            textBoxNotes.Text = originalStudent.Notes;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Обновляем свойства существующего объекта
            StudentManager.UpdateStudent(
                originalStudent,
                textBoxLastName.Text.Trim(),
                textBoxFirstName.Text.Trim(),
                textBoxPatronymic.Text.Trim(),
                dateTimePickerBirthDate.Value,
                comboBoxGender.SelectedItem.ToString(),
                comboBoxStudyBasis.SelectedItem.ToString(),
                int.Parse(textBoxDebtsCount.Text),
                textBoxNotes.Text.Trim()
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}