namespace Student
{
    class Prrogram
    {
        static void Main(string[] args)
        {

            {
                School school = new School();

                while (true)
                {
                    Console.WriteLine("1. Add Student");
                    Console.WriteLine("2. Display Student");
                    Console.WriteLine("3. Overall GPA");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("5. Select an option");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1 : 
                            Student student = new Student();
                            Console.WriteLine("Ennter Name");
                            student.Name = Console.ReadLine();
                            Console.WriteLine("Enter Age");
                            student.Age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Gender");
                            student.Gender = Console.ReadLine();
                            Console.WriteLine("Enter Course Enrollment");
                            student.CourseEnrollment = new List<string>(Console.ReadLine().Split(','));
                            student.AddStudent(student);
                            Console.WriteLine("Student added!");
                            break;

                        case 2 :
                            school.DisplayStudent();
                            break;

                        case 3 :
                            double overallGPA =  school.OverallGPA();
                            Console.WriteLine($"Overall GPA of Students in School : {overallGPA}");
                            break;

                        case 4 :
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }

                }


            }

        }
    }
}

    


