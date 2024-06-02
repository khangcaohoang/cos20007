using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProgram
{
    public class PhysicalProduct : Product
    {
        public double Weight { get; set; }

        public PhysicalProduct(string productId, string name, decimal price, int stockQuantity, double weight)
            : base(productId, name, price, stockQuantity)
        {
            Weight = weight;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Stock: {StockQuantity}");
            Console.WriteLine($"Weight: {Weight}kg");
        }
    }
}
