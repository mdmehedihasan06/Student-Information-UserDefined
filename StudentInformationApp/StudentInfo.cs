using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationApp
{
    public partial class StudentInfo : Form
    {
        Student aStudent = new Student();
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
            aStudent.id = idEntryTextBox.Text;
            aStudent.name = nameEntryTextBox.Text;
            aStudent.allowence = Convert.ToDouble(allowenceEntryTextBox.Text);
            aStudent.firstName = firstNameEntryTextBox.Text;
            aStudent.lastName = lastNameEntryTextBox.Text;
            MessageBox.Show(aStudent.GetFullName() + "(" + aStudent.name + "), " + "your ID is: " + aStudent.id + " and your allowence is: " + aStudent.allowence +" TK");
            
                //MessageBox.Show("Student Information is Given Below."+ "\nStudent ID: " + aStudent.id + "\nName: " + aStudent.name + "\nAllowence: " + aStudent.allowence);
            
            //idEntryTextBox.Text = string.Empty;
            //nameEntryTextBox.Text = string.Empty;
            //allowenceEntryTextBox.Text = string.Empty;
            ClearTextBox();
        }

        public void ClearTextBox()
        {
            idEntryTextBox.Text = string.Empty;
            nameEntryTextBox.Text = string.Empty;
            allowenceEntryTextBox.Text = string.Empty;
            firstNameEntryTextBox.Text = string.Empty;
            lastNameEntryTextBox.Text = string.Empty;
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            idEntryTextBox.Text = aStudent.id;
            nameEntryTextBox.Text = aStudent.name;
            allowenceEntryTextBox.Text = Convert.ToString(aStudent.allowence);
            firstNameEntryTextBox.Text = aStudent.firstName;
            lastNameEntryTextBox.Text = aStudent.lastName;
        }
    }
}
