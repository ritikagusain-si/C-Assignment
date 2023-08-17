using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        private string name;
        private int age;
        private string gender;
        private int studentId;
        private List<string> courseEnrollment = new List<string>();
        private double gpa;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public List<string> CourseEnrollment
        {
            get { return courseEnrollment; }
            set { courseEnrollment = value; }
        }

        public double GPA
        {
            get
            {
                double totalGradePoint = 0;

                foreach (string courseName in courseEnrollment)
                {
                    switch (courseName)
                    {
                        case "A": totalGradePoint += 5; break;
                        case "B": totalGradePoint += 4; break;
                        case "C": totalGradePoint += 3; break;
                        case "D": totalGradePoint += 2; break;
                        case "E": totalGradePoint += 1; break;
                    }
                }
                gpa = totalGradePoint / courseEnrollment.Count;
                return gpa;
            }
        }
    }
}
