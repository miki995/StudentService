using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StudentskaSluzba
{
    public partial class StudentForm : Form
    {
        private List<Student> students;
        private const string FILE_PATH = @".\students.txt";
        private bool isDataChanged;

        public StudentForm()
        {
            InitializeComponent();

            students = new List<Student>();
            isDataChanged = false;

            CenterToParent();
        }

        private void LoadStudents()
        {
            string[] serializedStudents = File.ReadAllLines(FILE_PATH);

            Student[] deserializedStudents = new Student[serializedStudents.Length];

            for (int i = 0; i < serializedStudents.Length; i++)
            {
                deserializedStudents[i] = Student.Deserialize(serializedStudents[i]);
            }

            students.AddRange(deserializedStudents);
        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student current = selectedStudent();
        
            fillStudentLabels(current);
            showStudentComponents();
        }

        private void fillStudentLabels(Student student)
        {
            firstNameLabel.Text = student.FirstName;
            lastNameLabel.Text = student.LastName;
            indexNumberLabel.Text = student.IndexNumber;
            studyProgramLabel.Text = student.StudyProgram;
            gradeAverageLabel.Text = student.GradeAverage.ToString();
        }

        private void showStudentComponents()
        {
            firstNameLabel.Visible = true;
            lastNameLabel.Visible = true;
            indexNumberLabel.Visible = true;
            studyProgramLabel.Visible = true;
            gradeAverageLabel.Visible = true;
            addGradeButton.Visible = true;
        }

        private Student selectedStudent()
        {
            return students[studentListBox.SelectedIndex];
        }

        private void saveStudents()
        {
            string[] serializedStudents = new string[students.Count];

            for (int i = 0; i < students.Count; i++)
            {
                serializedStudents[i] = students[i].Serialize();
            }

            File.WriteAllLines(FILE_PATH, serializedStudents);
        }
        private void addGradeButton_Click(object sender, EventArgs e)
        {
            GradeInputForm gradeInputForm = new GradeInputForm();
            DialogResult result = gradeInputForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int grade = gradeInputForm.Grade;

                Student current = selectedStudent();
                current.AddGrade(grade);

                fillStudentLabels(current);

                isDataChanged = true;
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            DialogResult result = addStudentForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Student newStudent = addStudentForm.Student;
                studentListBox.Items.Add(newStudent);
                students.Add(newStudent);

                isDataChanged = true;
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            saveStudents();

            MessageBox.Show("Uspješno sačuvano");

            isDataChanged = false;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            studentListBox.Items.AddRange(students.ToArray());
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDataChanged)
            {
                DialogResult result = MessageBox
                    .Show("Napravili ste promjene na podacima, bez čuvanja. Da li želite da sačuvate promjene?",
                          "Upozorenje", 
                          MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    saveStudents();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
