using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Final_RPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"C:\marksheet.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Grades dummy_grade = new Grades(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9]);
                    Lists.GradesList.Add(dummy_grade);
                }
            }
            InitializeListBoxValues();
        }
        private void InitializeListBoxValues()
        {
            listBox1.Items.Clear();
            foreach (Grades temp in Lists.GradesList)
            {
                listBox1.Items.Add(temp.getInfo());
            }
        
            foreach (Grades temp in Lists.GradesList)
            {
                if (temp.getID() == tb_ID.Text)
                {
                    tb_Attendance.Text = temp.getAttendance();
                    tb_Quiz1.Text = temp.getQuiz1();
                    tb_Quiz2.Text = temp.getQuiz2();
                    tb_Quiz3.Text = temp.getQuiz3();
                    tb_Quiz4.Text = temp.getQuiz4();
                    tb_Mid.Text = temp.getMid();
                    tb_Final.Text = temp.getFinal();
                    tb_Viva.Text = temp.getViva();
                }
            }
        }
    }
}
