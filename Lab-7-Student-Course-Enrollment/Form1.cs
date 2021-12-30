using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7_Student_Course_Enrollment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student>Studentlist=new List<Student>();
        List<Professional>Professionallist=new List<Professional>();
        List<Course> Courselist=new List<Course>();
        string Type, PLevel, CLevel;
        int Fee;
        string StudentLevel, CourseLevel;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AddParticipantOnClick(object sender, EventArgs e)
        {
            string Name = tb_Name.Text;
            string RegNo = tb_RegNo.Text;
            string Contact = tb_Contact.Text;
            string Email = tb_Email.Text;


            if (RB_Participant_Student.Checked == true)
            {
                Type = "Student";
            }
            else if (RB_Participant_Professional.Checked == true)
            {
                Type = "Professional";
            }

            if (RB_Level_Beginner.Checked == true)
            {
                PLevel = "Beginner";
            }
            else if (RB_Level_Intermediate.Checked == true)
            {
                PLevel = "Intermediate";
            }
            else if (RB_Level_Advanced.Checked == true)
            {
                PLevel = "Advanced";
            }
            else if (RB_Level_Beginner.Checked == false && RB_Level_Intermediate.Checked == false && RB_Level_Advanced.Checked == false && Type == "Student")
            {
                Student student = new Student(Name, RegNo, Contact, Email);
                PLevel = "Beginner";
                student.Level = PLevel;
                Studentlist.Add(student);
            }
            else if (RB_Level_Beginner.Checked == false && RB_Level_Intermediate.Checked == false && RB_Level_Advanced.Checked == false && Type == "Professional")
            {
                Professional professional = new Professional(Name, RegNo, Contact, Email);
                PLevel = "Beginner";
                professional.Level = PLevel;
                Professionallist.Add(professional);
            }

            if (Type == "Student" && PLevel != "")
            {
                Student student = new Student(Name, RegNo, Contact, Email, PLevel);
                Studentlist.Add(student);
            }
            else if (Type == "Professional" && PLevel != "")
            {
                Professional professional = new Professional(Name, RegNo, Contact, Email, PLevel);
                Professionallist.Add(professional);
            }

            cb_Enroll_Student.Items.Add(RegNo);
            MessageBox.Show("Participant Added");
        }

        private void AddCourse(object sender, EventArgs e)
        {
            string Title = tb_CourseTitle.Text;
            int Fee = Convert.ToInt32(tb_CourseFee.Text);

            if (RB_Course_Beginner.Checked == true)
            {
                CLevel = "Beginner";
            }
            else if (RB_Course_Intermediate.Checked == true)
            {
                CLevel = "Intermediate";
            }
            else if (RB_Course_Advanced.Checked == true)
            {
                CLevel = "Advanced";
            }
            Course course = new Course(Title, CLevel, Fee);
            Courselist.Add(course);
            cb_Enroll_Course.Items.Add(Title);
            MessageBox.Show("Course Added");
        }

        private void EnrollCourse(object sender, EventArgs e)
        {
            string course = cb_Enroll_Course.Text;
            string studentReg = cb_Enroll_Student.Text;
            string date = tb_Enroll_Date.Text;

            for (int i = 0; i < Studentlist.Count; i++)
            {
                if (studentReg == Studentlist[i].Reg)
                {
                    StudentLevel = Studentlist[i].Level;
                }
            }

            for (int i = 0; i < Professionallist.Count; i++)
            {
                if (studentReg == Professionallist[i].Reg)
                {
                    StudentLevel = Professionallist[i].Level;
                }
            }

            for (int i = 0; i < Courselist.Count; i++)
            {
                if (course == Courselist[i].Title)
                {
                    CourseLevel = Courselist[i].Level;
                }
            }

            if (CourseLevel == StudentLevel)
            {
                for (int i = 0; i < Courselist.Count; i++)
                {
                    if (course == Courselist[i].Title)
                    {
                        Fee = Courselist[i].Fee;
                        Courselist[i].EnrollDate = date;

                    }
                }
                for (int i = 0; i < Studentlist.Count; i++)
                {
                    if (studentReg == Studentlist[i].Reg)
                    {
                        Studentlist[i].Course = course;
                        lb_Enroll_CourseFee.Text = Convert.ToString(Studentlist[i].getCourseFee(Fee));
                    }
                }
                for (int i = 0; i < Professionallist.Count; i++)
                {
                    if (studentReg == Professionallist[i].Reg)
                    {
                        Professionallist[i].Course = course;
                        lb_Enroll_CourseFee.Text = Convert.ToString(Professionallist[i].getCourseFee(Fee));
                    }
                }
                cb_View_Student.Items.Add(studentReg);
                MessageBox.Show("Enrolled");
            }
            else
            {
                lb_Enroll_CourseFee.Text = "";
                MessageBox.Show("Course is on " + CourseLevel + " Level but Participant is on " + StudentLevel + " Level!");
            }

        }

        private void ShowEnrolled(object sender, EventArgs e)
        {
            Enrolled_Listbox.Items.Clear();
            Enrolled_Listbox.Items.Add("Name \t Level \t Date \t Fee");
            string studentReg = cb_View_Student.Text;

            for (int i = 0; i < Studentlist.Count; i++)
            {
                if (studentReg == Studentlist[i].Reg)
                {
                    string course = Studentlist[i].Course;

                    for (int j = 0; j < Courselist.Count; j++)
                    {
                        if (course == Courselist[j].Title)
                        {
                            Enrolled_Listbox.Items.Add(Courselist[j].getCourseInfo() +"\t" +Studentlist[i].getCourseFee(Courselist[j].Fee));
                        }
                    }
                }
            }

            for (int i = 0; i < Professionallist.Count; i++)
            {
                if (studentReg == Professionallist[i].Reg)
                {
                    string course = Professionallist[i].Course;

                    for (int j = 0; j < Courselist.Count; j++)
                    {
                        if (course == Courselist[j].Title)
                        {
                            Enrolled_Listbox.Items.Add(Courselist[j].getCourseInfo() + "\t" + Professionallist[i].getCourseFee(Courselist[j].Fee));
                        }
                    }
                }
            }
        }
    }
}
