namespace SR2
{
    partial class EditStudentForm
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
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelStudentCardNumber = new System.Windows.Forms.Label();
            this.textBoxStudentCardNumber = new System.Windows.Forms.TextBox();
            this.labelStudyBasis = new System.Windows.Forms.Label();
            this.comboBoxStudyBasis = new System.Windows.Forms.ComboBox();
            this.labelDebtsCount = new System.Windows.Forms.Label();
            this.textBoxDebtsCount = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(30, 30);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(71, 20);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Фамилия";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(200, 27);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(250, 27);
            this.textBoxLastName.TabIndex = 1;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(30, 70);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(39, 20);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Имя";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(200, 67);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(250, 27);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(30, 110);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(72, 20);
            this.labelPatronymic.TabIndex = 4;
            this.labelPatronymic.Text = "Отчество";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(200, 107);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(250, 27);
            this.textBoxPatronymic.TabIndex = 5;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(30, 150);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(116, 20);
            this.labelBirthDate.TabIndex = 6;
            this.labelBirthDate.Text = "Дата рождения";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(200, 147);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerBirthDate.TabIndex = 7;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(30, 190);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(37, 20);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "Пол";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "мужской",
            "женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(200, 187);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(250, 28);
            this.comboBoxGender.TabIndex = 9;
            // 
            // labelStudentCardNumber
            // 
            this.labelStudentCardNumber.AutoSize = true;
            this.labelStudentCardNumber.Location = new System.Drawing.Point(30, 230);
            this.labelStudentCardNumber.Name = "labelStudentCardNumber";
            this.labelStudentCardNumber.Size = new System.Drawing.Size(162, 20);
            this.labelStudentCardNumber.TabIndex = 10;
            this.labelStudentCardNumber.Text = "№ студ. билета";
            // 
            // textBoxStudentCardNumber
            // 
            this.textBoxStudentCardNumber.Location = new System.Drawing.Point(200, 227);
            this.textBoxStudentCardNumber.Name = "textBoxStudentCardNumber";
            this.textBoxStudentCardNumber.ReadOnly = true;
            this.textBoxStudentCardNumber.Size = new System.Drawing.Size(250, 27);
            this.textBoxStudentCardNumber.TabIndex = 11;
            // 
            // labelStudyBasis
            // 
            this.labelStudyBasis.AutoSize = true;
            this.labelStudyBasis.Location = new System.Drawing.Point(30, 270);
            this.labelStudyBasis.Name = "labelStudyBasis";
            this.labelStudyBasis.Size = new System.Drawing.Size(133, 20);
            this.labelStudyBasis.TabIndex = 12;
            this.labelStudyBasis.Text = "Основа обучения";
            // 
            // comboBoxStudyBasis
            // 
            this.comboBoxStudyBasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudyBasis.FormattingEnabled = true;
            this.comboBoxStudyBasis.Items.AddRange(new object[] {
            "бюджетная",
            "платная"});
            this.comboBoxStudyBasis.Location = new System.Drawing.Point(200, 267);
            this.comboBoxStudyBasis.Name = "comboBoxStudyBasis";
            this.comboBoxStudyBasis.Size = new System.Drawing.Size(250, 28);
            this.comboBoxStudyBasis.TabIndex = 13;
            // 
            // labelDebtsCount
            // 
            this.labelDebtsCount.AutoSize = true;
            this.labelDebtsCount.Location = new System.Drawing.Point(30, 310);
            this.labelDebtsCount.Name = "labelDebtsCount";
            this.labelDebtsCount.Size = new System.Drawing.Size(154, 20);
            this.labelDebtsCount.TabIndex = 14;
            this.labelDebtsCount.Text = "Кол-во задолж.";
            // 
            // textBoxDebtsCount
            // 
            this.textBoxDebtsCount.Location = new System.Drawing.Point(200, 307);
            this.textBoxDebtsCount.Name = "textBoxDebtsCount";
            this.textBoxDebtsCount.Size = new System.Drawing.Size(250, 27);
            this.textBoxDebtsCount.TabIndex = 15;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(30, 350);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(96, 20);
            this.labelNotes.TabIndex = 16;
            this.labelNotes.Text = "Примечание";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(200, 347);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(250, 27);
            this.textBoxNotes.TabIndex = 17;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(200, 400);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 35);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(330, 400);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 35);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.textBoxDebtsCount);
            this.Controls.Add(this.labelDebtsCount);
            this.Controls.Add(this.comboBoxStudyBasis);
            this.Controls.Add(this.labelStudyBasis);
            this.Controls.Add(this.textBoxStudentCardNumber);
            this.Controls.Add(this.labelStudentCardNumber);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование данных студента";
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}