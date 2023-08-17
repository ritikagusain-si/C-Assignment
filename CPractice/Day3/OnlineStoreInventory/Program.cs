namespace OnlineStoreInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Electronics laptop = new Electronics
            {
                ProductId = "E001",
                Name = "Laptop",
                Price = 20000,
                Quantity = 10,
                Brand = "Mac"
            };

            Clothing Tshirt = new Clothing
            {
                ProductId = "C001",
                Name = "T-Shirt",
                Price = 40,
                Quantity = 12,
                Size = "Small"
            };

            Books book = new Books
            {
                ProductId = "B001",
                Name = "Marvel",
                Price = 1000,
                Quantity = 50,
                Author = "R D"
            };

            Console.WriteLine("************ONLINE STORE INVENTORY SYSTEM**********");

            Console.WriteLine("------ELECTRONICS--------");
            laptop.DisplayDetails();

            Console.WriteLine("\n------CLOTHING---------");
            Tshirt.DisplayDetails();

            Console.WriteLine("\n--------BOOKS---------");
            book.DisplayDetails();


        }
    }
}