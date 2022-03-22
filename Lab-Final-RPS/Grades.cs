using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Final_RPS
{
    public class Grades
    {
        private string ID, Name;
        private string Attendance, Quiz1, Quiz2, Quiz3, Quiz4, Mid, Final, Viva;

        public Grades(string ID, string Name, string Attendance, string Quiz1, string Quiz2, string Quiz3, string Quiz4, string Mid, string Final, string Viva)
        {
            this.ID = ID;
            this.Name = Name;
            this.Attendance = Attendance;
            this.Quiz1 = Quiz1;
            this.Quiz2 = Quiz2;
            this.Quiz3 = Quiz3;
            this.Quiz4 = Quiz4;
            this.Mid = Mid;
            this.Final = Final;
            this.Viva = Viva;
        }
        public string getID()
        {
            return this.ID;
        }
        public string getAttendance() { return this.Attendance; }
        public string getQuiz1() { return this.Quiz1; }
        public string getQuiz2() { return this.Quiz2; }
        public string getQuiz3() { return this.Quiz3; }
        public string getQuiz4() { return this.Quiz4; }
        public string getMid() { return this.Mid; }
        public string getFinal() { return this.Final; }
        public string getViva() { return this.Viva; }
        public string getInfo()
        {
            return this.ID + " " + "\t" + this.Name + "\t\t\t\t" + this.Attendance + "\t" + this.Quiz1 + "\t" + this.Quiz2 + "\t" + this.Quiz3 + "\t" + this.Quiz4 + "\t" + this.Mid + "\t" + this.Final;
        }
        public string getTotal()
        {
            int att = Convert.ToInt32(this.Attendance);
            int q1 = Convert.ToInt32(this.Quiz1);
            int q2 = Convert.ToInt32(this.Quiz2);
            int q3 = Convert.ToInt32(this.Quiz3);
            int q4 = Convert.ToInt32(this.Quiz4);
            int mid = Convert.ToInt32(this.Mid);
            int final = Convert.ToInt32(this.Final);
            int viva = Convert.ToInt32(this.Viva);
            int quizsum = 0;
            int[] array = { q1, q2, q3, q4 };

            for (int i = 0; i <= 2; i++)
            {
                Array.Sort(array);
                Array.Reverse(array);
                quizsum += array[i];
            }
            int total = att + quizsum + mid + final + viva;
            return total.ToString();
        }

        public string getPercentage()
        {
            int tot = Convert.ToInt32(getTotal());
            double percentage = (tot * 100) / 300;
            return percentage.ToString();
        }

        public string getGrades()
        {
            string grade;
            double pert = Convert.ToDouble(getPercentage());
            if (pert >= 80)
                grade = "A+";
            else if (pert >= 75 && pert <= 79)
                grade = "A";
            else if (pert >= 70 && pert <= 74)
                grade = "A-";
            else if (pert >= 65 && pert <= 69)
                grade = "B+";
            else if (pert >= 64 && pert <= 60)
                grade = "B";
            else if (pert >= 55 && pert <= 59)
                grade = "B-";
            else if (pert >= 50 && pert <= 54)
                grade = "C+";
            else if (pert >= 45 && pert <= 49)
                grade = "C";
            else if (pert >= 40 && pert <= 44)
                grade = "D";
            else
                grade = "F";
            return grade;       
        }
    }
}
