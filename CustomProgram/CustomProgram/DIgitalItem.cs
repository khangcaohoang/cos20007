using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProgram
{
    public class DigitalProduct : Product
    {
        private double _filesize;
        public double FileSize
        {
            get
            {
                return _filesize;
            }
            set
            {
                _filesize = value;
            }
        }
        public DigitalProduct(string productId, string name, decimal price, int stockQuantity, double fileSize)
            : base(productId, name, price, stockQuantity)
        {
            FileSize = fileSize;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Stock: {StockQuantity}");
            Console.WriteLine($"File Size: {FileSize}MB");
        }
    }
}
