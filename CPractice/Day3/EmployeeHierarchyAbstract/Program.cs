namespace EmployeeHierarchyAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
            {
                Name = "Ritika",
                EmployeeId = 1,
                Salary = 1000000
            };

            Developer developer = new Developer
            {
                Name = "Shubham",
                EmployeeId = 2,
                Salary = 500000
            };

            SalesPerson salesperson = new SalesPerson
            {
                Name = "Annu",
                EmployeeId = 3,
                Salary = 300000  
            };

            Console.WriteLine("********EMPLOYEE DETAILS**********");

            Console.WriteLine("--------MANAGER---------");
            manager.DisplayDetails();

            Console.WriteLine("--------DEVELOPER-------");
            developer.DisplayDetails();

            Console.WriteLine("--------SALES PERSON-------");
            salesperson.DisplayDetails();
        }
    }
}