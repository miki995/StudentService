using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StudentskaSluzba
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string studyProgram;
        private string studyProgramShort;
        private int admitionNumber;
        private int admitionYear;
        private List<int> grades;

        public Student(string firstName, string lastName, string studyProgram, string indexNumber, int[] grades)
        {
            FirstName = firstName;
            LastName = lastName;
            StudyProgram = studyProgram;
            IndexNumber = indexNumber;
            this.grades = new List<int>(grades);
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length == 0)
                    throw new Exception("Ime ne može biti prazno");

                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length == 0)
                    throw new Exception("Prezime ne može biti prazno");

                lastName = value;
            }
        }

        public string StudyProgram
        {
            get
            {
                return studyProgram;
            }
            set
            {
                if (value.Length == 0)
                    throw new Exception("Studijski program ne može biti prazan");

                studyProgram = value;
            }
        }

        public string IndexNumber
        {
            get
            {
                return studyProgramShort + admitionNumber + '/' + admitionYear;
            }
            set
            {
                Regex indexNumberRegex = new Regex("^[A-Z]{2}[0-9]+/201[0-9]$");
                Match match = indexNumberRegex.Match(value);

                if (match.Success)
                {
                    string[] parts = value.Split('/');
                    this.studyProgramShort = parts[0].Substring(0, 2);
                    this.admitionNumber = Int16.Parse(parts[0].Substring(2));
                    this.admitionYear = Int16.Parse(parts[1]);
                }
                else
                {
                    throw new Exception("Loše formatiran broj indeksa");
                }
            }
        }

        public List<int> Grades
        {
            get
            {
                return grades;
            }
            set
            {
                grades = value;
            }
        }

        public float GradeAverage
        {
            get
            {
                float sum = 0;

                for (int i = 0; i < grades.Count; i++)
                {
                    sum += grades[i];
                }

                return sum / grades.Count;
            }
        }

        public void AddGrade(int grade)
        {
            if (grade < 6 || 10 < grade)
                throw new Exception("Grade must be between 6 and 10");

            grades.Add(grade);
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + IndexNumber;
        }

        public string Serialize()
        {
            return firstName + '|' + lastName + '|' + studyProgram + '|' + IndexNumber + '|' + String.Join(",", grades);
        }

        public static Student Deserialize(string serialized)
        {
            string[] parts = serialized.Split('|');

            string firstName = parts[0];
            string lastName = parts[1];
            string studyProgram = parts[2];
            string indexNumber = parts[3];
            string gradesConcat = parts[4];

            string[] gradeParts = gradesConcat.Split(',');
            int[] grades = new int[gradeParts.Length];
            
            for (int i = 0; i < gradeParts.Length; i++)
            {
                grades[i] = Int16.Parse(gradeParts[i]);
            }

            return new Student(firstName, lastName, studyProgram, indexNumber, grades);
        }
    }
}
