using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentArray
{
    class Student
    {
        public string Name { get; set; }

        public double[] grades;

        public Student(string name, int numGrades)
        {
            Name = name;
            grades = new double[numGrades];
        }

        public void EnterGrades()
        {
            for(int i = 0; i < grades.Length; i++)
            {
                bool validinput = false;

                while(!validinput)
                {
                    Console.WriteLine($"Enter grade {i + 1} : ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out double grade))
                    {
                        if (grade >= 0 && grade <= 100)
                        {
                            grades[i] = grade;
                            validinput = true;
                        }

                        else
                        {
                            Console.WriteLine("Invalid Input. Enter grade between 0 to 100.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. ENter numeric Value");
                    }
                }
            }
        }

        public double CalculateAverageGrade()
        {
            double sum = 0;
            foreach(double grade in grades)
            {
                sum += grade;
            }

            return sum / grades.Length;
        }
    }
}
