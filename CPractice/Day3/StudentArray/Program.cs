namespace StudentArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------STUDENT GRADING---------------");

            Console.WriteLine("Enter student Name : ");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter Student Grades : ");
            int numGrades = Convert.ToInt32(Console.ReadLine());

            Student student = new Student(studentName, numGrades);

            student.EnterGrades();

            double averageGrade = student.CalculateAverageGrade();

            Console.WriteLine($"Student : {student.Name}");
            Console.WriteLine($"Grades : {student.grades}");
            Console.WriteLine($"Average Grades : {averageGrade}");
        }
    }
}