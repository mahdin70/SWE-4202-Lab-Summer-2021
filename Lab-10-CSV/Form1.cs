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

namespace Lab_10_CSV
{
    public partial class Form1 : Form
    {
        public From1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"C:\employees.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Employee dummy_employee = new Employee(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[9], values[10],null);
                    Lists.employeeList.Add(dummy_employee);
                }
            }
            InitializeListBoxValues();

        }
        private void InitializeListBoxValues()
        {
            listBox1.Items.Clear();
            foreach (Employee temp in Lists.employeeList)
            {
                listBox1.Items.Add(temp.getInfo());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Employee temp in Lists.employeeList)
            {
                if (temp.getEmployeeID() == tb_SearchID.Text)
                {
                    EmployeeInformationData.Text = "Employee Information" + "\n" + temp.getDetailedInformation();
                    using (StreamWriter writer = new StreamWriter(@"C:\logs.txt"))
                    {
                        writer.WriteLine(temp.getInfo());
                    }
                }
            }
        }
    }
}

