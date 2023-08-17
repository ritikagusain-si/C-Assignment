using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class School
    {
        private List<Student> students = new List<Student>;

        public void AddStudent (Student student)
        {
            students.Add(student);
        }

        public void DisplayStudent(Student student)
        {
            Console.WriteLine("Display the list of Student");
            foreach(Student student in students)
            {
                Console.WriteLine($"Name :  {student.Name}, Age = {student.Age}, Gender : {student.Gender}, Student Id : {student.StudentId}");
            }
        }

        public double OverallGPA()
        {
            double totalGPA = 0;
            foreach(Student student in students)
            {
                totalGPA += student.GPA;
            }
            return totalGPA / students.Count;
        }
    }
}
