using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreInventory
{
    internal class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }


        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ProductId : {ProductId}");
            Console.WriteLine($"Product Name : {Name}");
            Console.WriteLine($"Product Price : {Price}");
            Console.WriteLine($"Product Quantity : {Quantity}");
        }
    }
}
