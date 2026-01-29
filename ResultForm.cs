namespace SR2
{
    public partial class ResultForm : Form
    {
        private List<Student> students;
        private bool allowEdit;

        public ResultForm(string title, List<Student> students, bool allowEdit)
        {
            InitializeComponent();
            this.Text = title;
            this.students = students;
            this.allowEdit = allowEdit;
            LoadData();
        }

        private void LoadData()
        {
            dataGridViewStudents.Rows.Clear();
            foreach (var student in students)
            {
                dataGridViewStudents.Rows.Add(
                    student.FullName,
                    student.StudentCardNumber,
                    student.Gender,
                    student.BirthDate.ToShortDateString(),
                    student.DebtsCount,
                    student.StudyBasis,
                    student.Notes
                );
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите студента для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранного студента?", 
                                        "Подтверждение", 
                                        MessageBoxButtons.YesNo, 
                                        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int rowIndex = dataGridViewStudents.SelectedRows[0].Index;
                var student = students[rowIndex];
                StudentManager.RemoveStudent(student);
                students.RemoveAt(rowIndex);
                LoadData();
                MessageBox.Show("Студент успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите студента для редактирования!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dataGridViewStudents.SelectedRows[0].Index;
            var student = students[rowIndex];

            var editForm = new EditStudentForm(student);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Данные студента успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            if (!allowEdit)
            {
                buttonEdit.Visible = false;
                buttonDelete.Visible = false;
            }
        }
    }
}