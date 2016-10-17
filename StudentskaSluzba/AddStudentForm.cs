using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskaSluzba
{
    public partial class AddStudentForm : Form
    {
        private Student student;
        public Student Student {
            get
            {
                return student;
            }
        }

        public AddStudentForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string studyProgram = studyProgramTextBox.Text;
            string indexNumber = indexNuberTextBox.Text;

            try
            {
                Student newStudent = new Student(firstName, lastName, studyProgram, indexNumber, new int[] { });

                student = newStudent;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
