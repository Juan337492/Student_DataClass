using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/****************************************************************
    Juan Rodriguez
    CIST 2341
    C# Programming 1
    Lab #10
This is my code....
*****************************************************************/
namespace Student_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 student = new Class1();
        
        private void fillBtn_Click(object sender, EventArgs e)
        {
            student.name = nameTextBox.Text;
            student.email = emailTextBox.Text;
            student.address = addressTextBox.Text;
            student.major = majorTextBox.Text;
            student.gpa = Convert.ToDouble(gpaTextBox.Text);
            student.phone = Convert.ToString(phoneTextBox.Text);

        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            student.Display();
        }
    }
}
