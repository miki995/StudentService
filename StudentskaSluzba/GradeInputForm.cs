using System;
using System.Windows.Forms;

namespace StudentskaSluzba
{
    public partial class GradeInputForm : Form
    {
        private int grade;
        public int Grade {
            get
            {
                return grade;
            }
        }

        public GradeInputForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                grade = getGrade();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                gradeTextBox.Text = "";
                gradeTextBox.Focus();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private int getGrade()
        {
            string userInput = gradeTextBox.Text;
            int grade = Int16.Parse(userInput);

            if (grade < 6 || 10 < grade)
                throw new Exception("Grade must be between 6 and 10.");

            return grade;
        }
    }
}
