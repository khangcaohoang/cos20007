using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProgram
{
    public abstract class Product
    {

        public string ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public Product(string productId, string name, decimal price, int stockQuantity)
        {
            ProductID = productId;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public abstract void DisplayDetails();
    }
}