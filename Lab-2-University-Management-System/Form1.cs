using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        List<StudentClass> studentInfoList = new List<StudentClass>();
        List<TeachersClass> TeachersInfoList = new List<TeachersClass>();
      
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void StudentInfoSaveButton_Click(object sender, EventArgs e)
        {
            string studentID = StudentIDTextBox.Text;
            string studentName = StudentNameTextBox.Text;
            string studentSemester = StudentSemesterTextBox.Text;
            string studentDepart = StudentDepartTextBox.Text;

            StudentClass dummy_std = new StudentClass
            {
                studentsID = studentID,
                studentsName = studentName,
                studentsSemester = studentSemester,
                studentsDepart = studentDepart
            };
            

            studentInfoList.Add(dummy_std);

            MessageBox.Show("Information has been added successfully");

        }

        private void StudentInfoClearButton_Click(object sender, EventArgs e)
        {
            StudentIDTextBox.Text = String.Empty;
            StudentNameTextBox.Text = String.Empty;
            StudentSemesterTextBox.Text = String.Empty;
            StudentDepartTextBox.Text = String.Empty;

            MessageBox.Show("Information has been cleared Successfully");

        }

        private void StudentInfoShowButton_Click(object sender, EventArgs e)
        {
            StudentInfoListBox.Items.Clear();

            for(int i=0; i<studentInfoList.Count; i++)
            {
                StudentInfoListBox.Items.Add(studentInfoList[i].getInfo());
            }
        }

        private void TeachersIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeachersInfoSaveButton_Click(object sender, EventArgs e)
        {
            string TeachersID = TeachersIDTextBox.Text;
            string TeachersName = TeachersNameTextBox.Text;
            string TeachersDepart = TeachersDepartTextBox.Text;
            string TeachersDesignation = TeachersDesignationTextBox.Text;
            string TeachersSalary = TeachersSalaryTextBox.Text;

            TeachersClass dummy_tc = new TeachersClass
            {
                TeachersID = TeachersID,
                TeachersName = TeachersName,
                TeachersDepart = TeachersDepart,
                TeachersDesignation = TeachersDesignation,
                TeachersSalary = TeachersSalary
            };

            TeachersInfoList.Add(dummy_tc);

            MessageBox.Show("Information has been added successfully");

        }

        private void TeachersInfoClearButton_Click(object sender, EventArgs e)
        {
            TeachersIDTextBox.Text = String.Empty;
            TeachersNameTextBox.Text = String.Empty;
            TeachersDepartTextBox.Text = String.Empty ;
            TeachersDesignationTextBox.Text = String.Empty ;
            TeachersSalaryTextBox.Text = String.Empty ;

            MessageBox.Show("Information has been cleared Successfully");
        }

        private void TeachersInfoShowButton_Click(object sender, EventArgs e)
        {
            TeachersInfoListBox.Items.Clear();

            for (int i=0; i<TeachersInfoList.Count; i++)
            {
                TeachersInfoListBox.Items.Add(TeachersInfoList[i].getInfo());
            }
        }

        private void StudentInfoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
