namespace SR2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelLastName = new Label();
            textBoxLastName = new TextBox();
            labelFirstName = new Label();
            textBoxFirstName = new TextBox();
            labelPatronymic = new Label();
            textBoxPatronymic = new TextBox();
            labelBirthDate = new Label();
            dateTimePickerBirthDate = new DateTimePicker();
            labelGender = new Label();
            comboBoxGender = new ComboBox();
            labelStudentCardNumber = new Label();
            textBoxStudentCardNumber = new TextBox();
            labelStudyBasis = new Label();
            comboBoxStudyBasis = new ComboBox();
            labelDebtsCount = new Label();
            textBoxDebtsCount = new TextBox();
            labelNotes = new Label();
            textBoxNotes = new TextBox();
            labelRecordCountText = new Label();
            labelRecordCount = new Label();
            buttonAddStudent = new Button();
            buttonShowAllStudents = new Button();
            buttonShowStudentsWithoutDebts = new Button();
            SuspendLayout();
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(49, 48);
            labelLastName.Margin = new Padding(5, 0, 5, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(113, 32);
            labelLastName.TabIndex = 0;
            labelLastName.Text = "Фамилия";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(325, 43);
            textBoxLastName.Margin = new Padding(5, 5, 5, 5);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(404, 39);
            textBoxLastName.TabIndex = 1;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(49, 112);
            labelFirstName.Margin = new Padding(5, 0, 5, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(61, 32);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "Имя";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(325, 107);
            textBoxFirstName.Margin = new Padding(5, 5, 5, 5);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(404, 39);
            textBoxFirstName.TabIndex = 3;
            // 
            // labelPatronymic
            // 
            labelPatronymic.AutoSize = true;
            labelPatronymic.Location = new Point(49, 176);
            labelPatronymic.Margin = new Padding(5, 0, 5, 0);
            labelPatronymic.Name = "labelPatronymic";
            labelPatronymic.Size = new Size(117, 32);
            labelPatronymic.TabIndex = 4;
            labelPatronymic.Text = "Отчество";
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Location = new Point(325, 171);
            textBoxPatronymic.Margin = new Padding(5, 5, 5, 5);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(404, 39);
            textBoxPatronymic.TabIndex = 5;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(49, 240);
            labelBirthDate.Margin = new Padding(5, 0, 5, 0);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(184, 32);
            labelBirthDate.TabIndex = 6;
            labelBirthDate.Text = "Дата рождения";
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Format = DateTimePickerFormat.Short;
            dateTimePickerBirthDate.Location = new Point(325, 235);
            dateTimePickerBirthDate.Margin = new Padding(5, 5, 5, 5);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(404, 39);
            dateTimePickerBirthDate.TabIndex = 7;
            dateTimePickerBirthDate.Value = new DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(49, 304);
            labelGender.Margin = new Padding(5, 0, 5, 0);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(58, 32);
            labelGender.TabIndex = 8;
            labelGender.Text = "Пол";
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "мужской", "женский" });
            comboBoxGender.Location = new Point(325, 299);
            comboBoxGender.Margin = new Padding(5, 5, 5, 5);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(404, 40);
            comboBoxGender.TabIndex = 9;
            // 
            // labelStudentCardNumber
            // 
            labelStudentCardNumber.AutoSize = true;
            labelStudentCardNumber.Location = new Point(49, 368);
            labelStudentCardNumber.Margin = new Padding(5, 0, 5, 0);
            labelStudentCardNumber.Name = "labelStudentCardNumber";
            labelStudentCardNumber.Size = new Size(182, 32);
            labelStudentCardNumber.TabIndex = 10;
            labelStudentCardNumber.Text = "№ студ. билета";
            // 
            // textBoxStudentCardNumber
            // 
            textBoxStudentCardNumber.Location = new Point(325, 363);
            textBoxStudentCardNumber.Margin = new Padding(5, 5, 5, 5);
            textBoxStudentCardNumber.Name = "textBoxStudentCardNumber";
            textBoxStudentCardNumber.Size = new Size(404, 39);
            textBoxStudentCardNumber.TabIndex = 11;
            // 
            // labelStudyBasis
            // 
            labelStudyBasis.AutoSize = true;
            labelStudyBasis.Location = new Point(49, 432);
            labelStudyBasis.Margin = new Padding(5, 0, 5, 0);
            labelStudyBasis.Name = "labelStudyBasis";
            labelStudyBasis.Size = new Size(210, 32);
            labelStudyBasis.TabIndex = 12;
            labelStudyBasis.Text = "Основа обучения";
            // 
            // comboBoxStudyBasis
            // 
            comboBoxStudyBasis.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStudyBasis.FormattingEnabled = true;
            comboBoxStudyBasis.Items.AddRange(new object[] { "бюджетная", "платная" });
            comboBoxStudyBasis.Location = new Point(325, 427);
            comboBoxStudyBasis.Margin = new Padding(5, 5, 5, 5);
            comboBoxStudyBasis.Name = "comboBoxStudyBasis";
            comboBoxStudyBasis.Size = new Size(404, 40);
            comboBoxStudyBasis.TabIndex = 13;
            // 
            // labelDebtsCount
            // 
            labelDebtsCount.AutoSize = true;
            labelDebtsCount.Location = new Point(49, 496);
            labelDebtsCount.Margin = new Padding(5, 0, 5, 0);
            labelDebtsCount.Name = "labelDebtsCount";
            labelDebtsCount.Size = new Size(185, 32);
            labelDebtsCount.TabIndex = 14;
            labelDebtsCount.Text = "Кол-во задолж.";
            // 
            // textBoxDebtsCount
            // 
            textBoxDebtsCount.Location = new Point(325, 491);
            textBoxDebtsCount.Margin = new Padding(5, 5, 5, 5);
            textBoxDebtsCount.Name = "textBoxDebtsCount";
            textBoxDebtsCount.Size = new Size(404, 39);
            textBoxDebtsCount.TabIndex = 15;
            textBoxDebtsCount.Text = "0";
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(49, 560);
            labelNotes.Margin = new Padding(5, 0, 5, 0);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(156, 32);
            labelNotes.TabIndex = 16;
            labelNotes.Text = "Примечание";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(325, 555);
            textBoxNotes.Margin = new Padding(5, 5, 5, 5);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(404, 39);
            textBoxNotes.TabIndex = 17;
            // 
            // labelRecordCountText
            // 
            labelRecordCountText.AutoSize = true;
            labelRecordCountText.Location = new Point(812, 48);
            labelRecordCountText.Margin = new Padding(5, 0, 5, 0);
            labelRecordCountText.Name = "labelRecordCountText";
            labelRecordCountText.Size = new Size(245, 32);
            labelRecordCountText.TabIndex = 18;
            labelRecordCountText.Text = "Количество записей:";
            // 
            // labelRecordCount
            // 
            labelRecordCount.AutoSize = true;
            labelRecordCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelRecordCount.Location = new Point(1089, 43);
            labelRecordCount.Margin = new Padding(5, 0, 5, 0);
            labelRecordCount.Name = "labelRecordCount";
            labelRecordCount.Size = new Size(38, 45);
            labelRecordCount.TabIndex = 19;
            labelRecordCount.Text = "0";
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(49, 640);
            buttonAddStudent.Margin = new Padding(5, 5, 5, 5);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(682, 64);
            buttonAddStudent.TabIndex = 20;
            buttonAddStudent.Text = "Добавить студента";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonShowAllStudents
            // 
            buttonShowAllStudents.Location = new Point(812, 160);
            buttonShowAllStudents.Margin = new Padding(5, 5, 5, 5);
            buttonShowAllStudents.Name = "buttonShowAllStudents";
            buttonShowAllStudents.Size = new Size(455, 80);
            buttonShowAllStudents.TabIndex = 21;
            buttonShowAllStudents.Text = "Показать список группы\r\n(алфавитный порядок)";
            buttonShowAllStudents.UseVisualStyleBackColor = true;
            buttonShowAllStudents.Click += buttonShowAllStudents_Click;
            // 
            // buttonShowStudentsWithoutDebts
            // 
            buttonShowStudentsWithoutDebts.Location = new Point(812, 272);
            buttonShowStudentsWithoutDebts.Margin = new Padding(5, 5, 5, 5);
            buttonShowStudentsWithoutDebts.Name = "buttonShowStudentsWithoutDebts";
            buttonShowStudentsWithoutDebts.Size = new Size(455, 80);
            buttonShowStudentsWithoutDebts.TabIndex = 22;
            buttonShowStudentsWithoutDebts.Text = "Студенты без задолженностей\r\n(сортировка по № студ. билета)";
            buttonShowStudentsWithoutDebts.UseVisualStyleBackColor = true;
            buttonShowStudentsWithoutDebts.Click += buttonShowStudentsWithoutDebts_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 768);
            Controls.Add(buttonShowStudentsWithoutDebts);
            Controls.Add(buttonShowAllStudents);
            Controls.Add(buttonAddStudent);
            Controls.Add(labelRecordCount);
            Controls.Add(labelRecordCountText);
            Controls.Add(textBoxNotes);
            Controls.Add(labelNotes);
            Controls.Add(textBoxDebtsCount);
            Controls.Add(labelDebtsCount);
            Controls.Add(comboBoxStudyBasis);
            Controls.Add(labelStudyBasis);
            Controls.Add(textBoxStudentCardNumber);
            Controls.Add(labelStudentCardNumber);
            Controls.Add(comboBoxGender);
            Controls.Add(labelGender);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(labelBirthDate);
            Controls.Add(textBoxPatronymic);
            Controls.Add(labelPatronymic);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Кучменко Илья Владимирович, ЭБЦД-211";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelStudentCardNumber;
        private System.Windows.Forms.TextBox textBoxStudentCardNumber;
        private System.Windows.Forms.Label labelStudyBasis;
        private System.Windows.Forms.ComboBox comboBoxStudyBasis;
        private System.Windows.Forms.Label labelDebtsCount;
        private System.Windows.Forms.TextBox textBoxDebtsCount;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelRecordCountText;
        private System.Windows.Forms.Label labelRecordCount;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonShowAllStudents;
        private System.Windows.Forms.Button buttonShowStudentsWithoutDebts;
    }
}
