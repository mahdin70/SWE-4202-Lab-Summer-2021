namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentSemesterTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentDepartTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentInfoClearButton = new System.Windows.Forms.Button();
            this.StudentInfoSaveButton = new System.Windows.Forms.Button();
            this.StudentInfoListBox = new System.Windows.Forms.ListBox();
            this.StudentInfoShowButton = new System.Windows.Forms.Button();
            this.TeachersInfoShowButton = new System.Windows.Forms.Button();
            this.TeachersInfoListBox = new System.Windows.Forms.ListBox();
            this.TeachersInfoSaveButton = new System.Windows.Forms.Button();
            this.TeachersInfoClearButton = new System.Windows.Forms.Button();
            this.TeachersDesignationTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TeachersDepartTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TeachersNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TeachersIDTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TeachersSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Location = new System.Drawing.Point(157, 105);
            this.StudentIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.Size = new System.Drawing.Size(175, 22);
            this.StudentIDTextBox.TabIndex = 2;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(157, 137);
            this.StudentNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(175, 22);
            this.StudentNameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // StudentSemesterTextBox
            // 
            this.StudentSemesterTextBox.Location = new System.Drawing.Point(157, 169);
            this.StudentSemesterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentSemesterTextBox.Name = "StudentSemesterTextBox";
            this.StudentSemesterTextBox.Size = new System.Drawing.Size(175, 22);
            this.StudentSemesterTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Semester:";
            // 
            // StudentDepartTextBox
            // 
            this.StudentDepartTextBox.Location = new System.Drawing.Point(157, 201);
            this.StudentDepartTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentDepartTextBox.Name = "StudentDepartTextBox";
            this.StudentDepartTextBox.Size = new System.Drawing.Size(175, 22);
            this.StudentDepartTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Department:";
            // 
            // StudentInfoClearButton
            // 
            this.StudentInfoClearButton.ForeColor = System.Drawing.Color.Black;
            this.StudentInfoClearButton.Location = new System.Drawing.Point(60, 271);
            this.StudentInfoClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.StudentInfoClearButton.Name = "StudentInfoClearButton";
            this.StudentInfoClearButton.Size = new System.Drawing.Size(100, 28);
            this.StudentInfoClearButton.TabIndex = 9;
            this.StudentInfoClearButton.Text = "Clear";
            this.StudentInfoClearButton.UseVisualStyleBackColor = true;
            this.StudentInfoClearButton.Click += new System.EventHandler(this.StudentInfoClearButton_Click);
            // 
            // StudentInfoSaveButton
            // 
            this.StudentInfoSaveButton.Location = new System.Drawing.Point(232, 271);
            this.StudentInfoSaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.StudentInfoSaveButton.Name = "StudentInfoSaveButton";
            this.StudentInfoSaveButton.Size = new System.Drawing.Size(100, 28);
            this.StudentInfoSaveButton.TabIndex = 10;
            this.StudentInfoSaveButton.Text = "Save";
            this.StudentInfoSaveButton.UseVisualStyleBackColor = true;
            this.StudentInfoSaveButton.Click += new System.EventHandler(this.StudentInfoSaveButton_Click);
            // 
            // StudentInfoListBox
            // 
            this.StudentInfoListBox.FormattingEnabled = true;
            this.StudentInfoListBox.ItemHeight = 16;
            this.StudentInfoListBox.Location = new System.Drawing.Point(467, 105);
            this.StudentInfoListBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentInfoListBox.Name = "StudentInfoListBox";
            this.StudentInfoListBox.Size = new System.Drawing.Size(511, 148);
            this.StudentInfoListBox.TabIndex = 11;
            this.StudentInfoListBox.SelectedIndexChanged += new System.EventHandler(this.StudentInfoListBox_SelectedIndexChanged);
            // 
            // StudentInfoShowButton
            // 
            this.StudentInfoShowButton.Location = new System.Drawing.Point(665, 271);
            this.StudentInfoShowButton.Margin = new System.Windows.Forms.Padding(4);
            this.StudentInfoShowButton.Name = "StudentInfoShowButton";
            this.StudentInfoShowButton.Size = new System.Drawing.Size(100, 28);
            this.StudentInfoShowButton.TabIndex = 12;
            this.StudentInfoShowButton.Text = "Show Info";
            this.StudentInfoShowButton.UseVisualStyleBackColor = true;
            this.StudentInfoShowButton.Click += new System.EventHandler(this.StudentInfoShowButton_Click);
            // 
            // TeachersInfoShowButton
            // 
            this.TeachersInfoShowButton.Location = new System.Drawing.Point(665, 569);
            this.TeachersInfoShowButton.Margin = new System.Windows.Forms.Padding(4);
            this.TeachersInfoShowButton.Name = "TeachersInfoShowButton";
            this.TeachersInfoShowButton.Size = new System.Drawing.Size(100, 28);
            this.TeachersInfoShowButton.TabIndex = 25;
            this.TeachersInfoShowButton.Text = "Show Info";
            this.TeachersInfoShowButton.UseVisualStyleBackColor = true;
            this.TeachersInfoShowButton.Click += new System.EventHandler(this.TeachersInfoShowButton_Click);
            // 
            // TeachersInfoListBox
            // 
            this.TeachersInfoListBox.FormattingEnabled = true;
            this.TeachersInfoListBox.ItemHeight = 16;
            this.TeachersInfoListBox.Location = new System.Drawing.Point(467, 386);
            this.TeachersInfoListBox.Margin = new System.Windows.Forms.Padding(4);
            this.TeachersInfoListBox.Name = "TeachersInfoListBox";
            this.TeachersInfoListBox.Size = new System.Drawing.Size(511, 148);
            this.TeachersInfoListBox.TabIndex = 24;
            // 
            // TeachersInfoSaveButton
            // 
            this.TeachersInfoSaveButton.Location = new System.Drawing.Point(233, 569);
            this.TeachersInfoSaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.TeachersInfoSaveButton.Name = "TeachersInfoSaveButton";
            this.TeachersInfoSaveButton.Size = new System.Drawing.Size(100, 28);
            this.TeachersInfoSaveButton.TabIndex = 23;
            this.TeachersInfoSaveButton.Text = "Save";
            this.TeachersInfoSaveButton.UseVisualStyleBackColor = true;
            this.TeachersInfoSaveButton.Click += new System.EventHandler(this.TeachersInfoSaveButton_Click);
            // 
            // TeachersInfoClearButton
            // 
            this.TeachersInfoClearButton.Location = new System.Drawing.Point(67, 569);
            this.TeachersInfoClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.TeachersInfoClearButton.Name = "TeachersInfoClearButton";
            this.TeachersInfoClearButton.Size = new System.Drawing.Size(100, 28);
            this.TeachersInfoClearButton.TabIndex = 22;
            this.TeachersInfoClearButton.Text = "Clear";
            this.TeachersInfoClearButton.UseVisualStyleBackColor = true;
            this.TeachersInfoClearButton.Click += new System.EventHandler(this.TeachersInfoClearButton_Click);
            // 
            // TeachersDesignationTextBox
            // 
            this.TeachersDesignationTextBox.Location = new System.Drawing.Point(157, 482);
            this.TeachersDesignationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TeachersDesignationTextBox.Name = "TeachersDesignationTextBox";
            this.TeachersDesignationTextBox.Size = new System.Drawing.Size(175, 22);
            this.TeachersDesignationTextBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 454);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Department:";
            // 
            // TeachersDepartTextBox
            // 
            this.TeachersDepartTextBox.Location = new System.Drawing.Point(157, 450);
            this.TeachersDepartTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TeachersDepartTextBox.Name = "TeachersDepartTextBox";
            this.TeachersDepartTextBox.Size = new System.Drawing.Size(175, 22);
            this.TeachersDepartTextBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 487);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Designation:";
            // 
            // TeachersNameTextBox
            // 
            this.TeachersNameTextBox.Location = new System.Drawing.Point(157, 418);
            this.TeachersNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TeachersNameTextBox.Name = "TeachersNameTextBox";
            this.TeachersNameTextBox.Size = new System.Drawing.Size(175, 22);
            this.TeachersNameTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 422);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name:";
            // 
            // TeachersIDTextBox
            // 
            this.TeachersIDTextBox.Location = new System.Drawing.Point(157, 386);
            this.TeachersIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TeachersIDTextBox.Name = "TeachersIDTextBox";
            this.TeachersIDTextBox.Size = new System.Drawing.Size(175, 22);
            this.TeachersIDTextBox.TabIndex = 15;
            this.TeachersIDTextBox.TextChanged += new System.EventHandler(this.TeachersIDTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 390);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(55, 340);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Teachers";
            // 
            // TeachersSalaryTextBox
            // 
            this.TeachersSalaryTextBox.Location = new System.Drawing.Point(157, 514);
            this.TeachersSalaryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TeachersSalaryTextBox.Name = "TeachersSalaryTextBox";
            this.TeachersSalaryTextBox.Size = new System.Drawing.Size(175, 22);
            this.TeachersSalaryTextBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 519);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Salary:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1068, 686);
            this.Controls.Add(this.TeachersSalaryTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TeachersInfoShowButton);
            this.Controls.Add(this.TeachersInfoListBox);
            this.Controls.Add(this.TeachersInfoSaveButton);
            this.Controls.Add(this.TeachersInfoClearButton);
            this.Controls.Add(this.TeachersDesignationTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TeachersDepartTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TeachersNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TeachersIDTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StudentInfoShowButton);
            this.Controls.Add(this.StudentInfoListBox);
            this.Controls.Add(this.StudentInfoSaveButton);
            this.Controls.Add(this.StudentInfoClearButton);
            this.Controls.Add(this.StudentDepartTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StudentSemesterTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "School Management System ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentIDTextBox;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StudentSemesterTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StudentDepartTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StudentInfoClearButton;
        private System.Windows.Forms.Button StudentInfoSaveButton;
        private System.Windows.Forms.ListBox StudentInfoListBox;
        private System.Windows.Forms.Button StudentInfoShowButton;
        private System.Windows.Forms.Button TeachersInfoShowButton;
        private System.Windows.Forms.ListBox TeachersInfoListBox;
        private System.Windows.Forms.Button TeachersInfoSaveButton;
        private System.Windows.Forms.Button TeachersInfoClearButton;
        private System.Windows.Forms.TextBox TeachersDesignationTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TeachersDepartTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TeachersNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TeachersIDTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TeachersSalaryTextBox;
        private System.Windows.Forms.Label label11;
    }
}

