namespace Lab_7_Student_Course_Enrollment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RB_Level_Advanced = new System.Windows.Forms.RadioButton();
            this.RB_Level_Intermediate = new System.Windows.Forms.RadioButton();
            this.RB_Level_Beginner = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_Participant_Professional = new System.Windows.Forms.RadioButton();
            this.RB_Participant_Student = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_RegNo = new System.Windows.Forms.TextBox();
            this.tb_Contact = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RB_Course_Advanced = new System.Windows.Forms.RadioButton();
            this.RB_Course_Intermediate = new System.Windows.Forms.RadioButton();
            this.RB_Course_Beginner = new System.Windows.Forms.RadioButton();
            this.tb_CourseFee = new System.Windows.Forms.TextBox();
            this.tb_CourseTitle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cb_Enroll_Course = new System.Windows.Forms.ComboBox();
            this.cb_Enroll_Student = new System.Windows.Forms.ComboBox();
            this.lb_Enroll_CourseFee = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Enrolled_Listbox = new System.Windows.Forms.ListBox();
            this.cb_View_Student = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_Enroll_Date = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_Email);
            this.groupBox1.Controls.Add(this.tb_RegNo);
            this.groupBox1.Controls.Add(this.tb_Contact);
            this.groupBox1.Controls.Add(this.tb_Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(412, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Participant Information";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 180);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddParticipantOnClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Level";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RB_Level_Advanced);
            this.groupBox3.Controls.Add(this.RB_Level_Intermediate);
            this.groupBox3.Controls.Add(this.RB_Level_Beginner);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(294, 116);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(114, 97);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // RB_Level_Advanced
            // 
            this.RB_Level_Advanced.AutoSize = true;
            this.RB_Level_Advanced.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Level_Advanced.Location = new System.Drawing.Point(4, 64);
            this.RB_Level_Advanced.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_Level_Advanced.Name = "RB_Level_Advanced";
            this.RB_Level_Advanced.Size = new System.Drawing.Size(85, 21);
            this.RB_Level_Advanced.TabIndex = 2;
            this.RB_Level_Advanced.TabStop = true;
            this.RB_Level_Advanced.Text = "Advanced";
            this.RB_Level_Advanced.UseVisualStyleBackColor = true;
            // 
            // RB_Level_Intermediate
            // 
            this.RB_Level_Intermediate.AutoSize = true;
            this.RB_Level_Intermediate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Level_Intermediate.Location = new System.Drawing.Point(4, 39);
            this.RB_Level_Intermediate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_Level_Intermediate.Name = "RB_Level_Intermediate";
            this.RB_Level_Intermediate.Size = new System.Drawing.Size(103, 21);
            this.RB_Level_Intermediate.TabIndex = 1;
            this.RB_Level_Intermediate.TabStop = true;
            this.RB_Level_Intermediate.Text = "Intermediate";
            this.RB_Level_Intermediate.UseVisualStyleBackColor = true;
            // 
            // RB_Level_Beginner
            // 
            this.RB_Level_Beginner.AutoSize = true;
            this.RB_Level_Beginner.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Level_Beginner.Location = new System.Drawing.Point(4, 15);
            this.RB_Level_Beginner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_Level_Beginner.Name = "RB_Level_Beginner";
            this.RB_Level_Beginner.Size = new System.Drawing.Size(79, 21);
            this.RB_Level_Beginner.TabIndex = 0;
            this.RB_Level_Beginner.TabStop = true;
            this.RB_Level_Beginner.Text = "Beginner";
            this.RB_Level_Beginner.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_Participant_Professional);
            this.groupBox2.Controls.Add(this.RB_Participant_Student);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(294, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(114, 77);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // RB_Participant_Professional
            // 
            this.RB_Participant_Professional.AutoSize = true;
            this.RB_Participant_Professional.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Participant_Professional.Location = new System.Drawing.Point(4, 39);
            this.RB_Participant_Professional.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_Participant_Professional.Name = "RB_Participant_Professional";
            this.RB_Participant_Professional.Size = new System.Drawing.Size(98, 21);
            this.RB_Participant_Professional.TabIndex = 1;
            this.RB_Participant_Professional.TabStop = true;
            this.RB_Participant_Professional.Text = "Professional";
            this.RB_Participant_Professional.UseVisualStyleBackColor = true;
            // 
            // RB_Participant_Student
            // 
            this.RB_Participant_Student.AutoSize = true;
            this.RB_Participant_Student.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Participant_Student.Location = new System.Drawing.Point(4, 15);
            this.RB_Participant_Student.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_Participant_Student.Name = "RB_Participant_Student";
            this.RB_Participant_Student.Size = new System.Drawing.Size(74, 21);
            this.RB_Participant_Student.TabIndex = 0;
            this.RB_Participant_Student.TabStop = true;
            this.RB_Participant_Student.Text = "Student";
            this.RB_Participant_Student.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type";
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(74, 142);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(153, 23);
            this.tb_Email.TabIndex = 7;
            // 
            // tb_RegNo
            // 
            this.tb_RegNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RegNo.Location = new System.Drawing.Point(74, 72);
            this.tb_RegNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_RegNo.Name = "tb_RegNo";
            this.tb_RegNo.Size = new System.Drawing.Size(153, 23);
            this.tb_RegNo.TabIndex = 6;
            // 
            // tb_Contact
            // 
            this.tb_Contact.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Contact.Location = new System.Drawing.Point(74, 108);
            this.tb_Contact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Contact.Name = "tb_Contact";
            this.tb_Contact.Size = new System.Drawing.Size(153, 23);
            this.tb_Contact.TabIndex = 5;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(74, 37);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(153, 23);
            this.tb_Name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reg. No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.tb_CourseFee);
            this.groupBox4.Controls.Add(this.tb_CourseTitle);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 255);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(412, 169);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Course Information";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(84, 114);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddCourse);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Level";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RB_Course_Advanced);
            this.groupBox5.Controls.Add(this.RB_Course_Intermediate);
            this.groupBox5.Controls.Add(this.RB_Course_Beginner);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(287, 25);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(121, 97);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // RB_Course_Advanced
            // 
            this.RB_Course_Advanced.AutoSize = true;
            this.RB_Course_Advanced.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Course_Advanced.Location = new System.Drawing.Point(4, 64);
            this.RB_Course_Advanced.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_Course_Advanced.Name = "RB_Course_Advanced";
            this.RB_Course_Advanced.Size = new System.Drawing.Size(85, 21);
            this.RB_Course_Advanced.TabIndex = 2;
            this.RB_Course_Advanced.TabStop = true;
            this.RB_Course_Advanced.Text = "Advanced";
            this.RB_Course_Advanced.UseVisualStyleBackColor = true;
            // 
            // RB_Course_Intermediate
            // 
            this.RB_Course_Intermediate.AutoSize = true;
            this.RB_Course_Intermediate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Course_Intermediate.Location = new System.Drawing.Point(4, 39);
            this.RB_Course_Intermediate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_Course_Intermediate.Name = "RB_Course_Intermediate";
            this.RB_Course_Intermediate.Size = new System.Drawing.Size(103, 21);
            this.RB_Course_Intermediate.TabIndex = 1;
            this.RB_Course_Intermediate.TabStop = true;
            this.RB_Course_Intermediate.Text = "Intermediate";
            this.RB_Course_Intermediate.UseVisualStyleBackColor = true;
            // 
            // RB_Course_Beginner
            // 
            this.RB_Course_Beginner.AutoSize = true;
            this.RB_Course_Beginner.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Course_Beginner.Location = new System.Drawing.Point(4, 15);
            this.RB_Course_Beginner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_Course_Beginner.Name = "RB_Course_Beginner";
            this.RB_Course_Beginner.Size = new System.Drawing.Size(79, 21);
            this.RB_Course_Beginner.TabIndex = 0;
            this.RB_Course_Beginner.TabStop = true;
            this.RB_Course_Beginner.Text = "Beginner";
            this.RB_Course_Beginner.UseVisualStyleBackColor = true;
            // 
            // tb_CourseFee
            // 
            this.tb_CourseFee.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CourseFee.Location = new System.Drawing.Point(83, 72);
            this.tb_CourseFee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_CourseFee.Name = "tb_CourseFee";
            this.tb_CourseFee.Size = new System.Drawing.Size(153, 23);
            this.tb_CourseFee.TabIndex = 6;
            // 
            // tb_CourseTitle
            // 
            this.tb_CourseTitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CourseTitle.Location = new System.Drawing.Point(83, 37);
            this.tb_CourseTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_CourseTitle.Name = "tb_CourseTitle";
            this.tb_CourseTitle.Size = new System.Drawing.Size(153, 23);
            this.tb_CourseTitle.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 77);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Course Fee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 42);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Title";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tb_Enroll_Date);
            this.groupBox6.Controls.Add(this.cb_Enroll_Course);
            this.groupBox6.Controls.Add(this.cb_Enroll_Student);
            this.groupBox6.Controls.Add(this.lb_Enroll_CourseFee);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(425, 18);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(285, 231);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Enroll in a Course";
            // 
            // cb_Enroll_Course
            // 
            this.cb_Enroll_Course.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Enroll_Course.FormattingEnabled = true;
            this.cb_Enroll_Course.Location = new System.Drawing.Point(111, 72);
            this.cb_Enroll_Course.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Enroll_Course.Name = "cb_Enroll_Course";
            this.cb_Enroll_Course.Size = new System.Drawing.Size(128, 23);
            this.cb_Enroll_Course.TabIndex = 16;
            // 
            // cb_Enroll_Student
            // 
            this.cb_Enroll_Student.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Enroll_Student.FormattingEnabled = true;
            this.cb_Enroll_Student.Location = new System.Drawing.Point(111, 37);
            this.cb_Enroll_Student.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Enroll_Student.Name = "cb_Enroll_Student";
            this.cb_Enroll_Student.Size = new System.Drawing.Size(128, 23);
            this.cb_Enroll_Student.TabIndex = 15;
            // 
            // lb_Enroll_CourseFee
            // 
            this.lb_Enroll_CourseFee.AutoSize = true;
            this.lb_Enroll_CourseFee.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Enroll_CourseFee.ForeColor = System.Drawing.Color.Red;
            this.lb_Enroll_CourseFee.Location = new System.Drawing.Point(108, 149);
            this.lb_Enroll_CourseFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Enroll_CourseFee.Name = "lb_Enroll_CourseFee";
            this.lb_Enroll_CourseFee.Size = new System.Drawing.Size(28, 15);
            this.lb_Enroll_CourseFee.TabIndex = 14;
            this.lb_Enroll_CourseFee.Text = "BDT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(26, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Course Fee :";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(104, 180);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 24);
            this.button3.TabIndex = 12;
            this.button3.Text = "Pay and Enroll";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.EnrollCourse);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 115);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Enrollment Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 77);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Select Course";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 42);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Select Student";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Enrolled_Listbox);
            this.groupBox7.Controls.Add(this.cb_View_Student);
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(425, 254);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Size = new System.Drawing.Size(285, 214);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "View Enrolled Courses";
            // 
            // Enrolled_Listbox
            // 
            this.Enrolled_Listbox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enrolled_Listbox.FormattingEnabled = true;
            this.Enrolled_Listbox.ItemHeight = 15;
            this.Enrolled_Listbox.Location = new System.Drawing.Point(10, 106);
            this.Enrolled_Listbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Enrolled_Listbox.Name = "Enrolled_Listbox";
            this.Enrolled_Listbox.Size = new System.Drawing.Size(272, 79);
            this.Enrolled_Listbox.TabIndex = 17;
            // 
            // cb_View_Student
            // 
            this.cb_View_Student.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_View_Student.FormattingEnabled = true;
            this.cb_View_Student.Location = new System.Drawing.Point(104, 37);
            this.cb_View_Student.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_View_Student.Name = "cb_View_Student";
            this.cb_View_Student.Size = new System.Drawing.Size(135, 23);
            this.cb_View_Student.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(104, 68);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 24);
            this.button4.TabIndex = 12;
            this.button4.Text = "Show Enrolled";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ShowEnrolled);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 42);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "Select Student";
            // 
            // tb_Enroll_Date
            // 
            this.tb_Enroll_Date.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Enroll_Date.Location = new System.Drawing.Point(111, 108);
            this.tb_Enroll_Date.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Enroll_Date.Name = "tb_Enroll_Date";
            this.tb_Enroll_Date.Size = new System.Drawing.Size(128, 23);
            this.tb_Enroll_Date.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 469);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Student Course Enrollment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RB_Level_Advanced;
        private System.Windows.Forms.RadioButton RB_Level_Intermediate;
        private System.Windows.Forms.RadioButton RB_Level_Beginner;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB_Participant_Professional;
        private System.Windows.Forms.RadioButton RB_Participant_Student;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_RegNo;
        private System.Windows.Forms.TextBox tb_Contact;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton RB_Course_Advanced;
        private System.Windows.Forms.RadioButton RB_Course_Intermediate;
        private System.Windows.Forms.RadioButton RB_Course_Beginner;
        private System.Windows.Forms.TextBox tb_CourseFee;
        private System.Windows.Forms.TextBox tb_CourseTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cb_Enroll_Course;
        private System.Windows.Forms.ComboBox cb_Enroll_Student;
        private System.Windows.Forms.Label lb_Enroll_CourseFee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cb_View_Student;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox Enrolled_Listbox;
        private System.Windows.Forms.TextBox tb_Enroll_Date;
    }
}

