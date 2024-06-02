using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProgram
{
    public class ShoppingCart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public void AddItem(Product product, int quantity)
        {
            if (product.StockQuantity >= quantity)
            {
                CartItem item = new CartItem(product, quantity);
                Items.Add(item);
                product.StockQuantity -= quantity;
                Console.WriteLine($"{quantity} x {product.Name} added to cart.");
            }
            else
            {
                Console.WriteLine($"Insufficient stock for {product.Name}.");
            }
        }

        public void ViewDetails(int index)
        {
            if (index >= 0 && index < Items.Count)
            {
                Items[index].DisplayItemDetails();
            }
            else
            {
                Console.WriteLine("Invalid item index.");
            }
        }
        public void DisplayCart()
        {
            int i = 1;
            Console.WriteLine("Your shopping cart:");
            foreach (var item in Items)
            {
                Console.WriteLine($"[{i}] {item.Quantity} x {item.Product.Name} @ {item.Product.Price:C} each - Total: {item.GetTotalPrice():C}");
                i += 1;
            }
        }

        public decimal GetTotalAmount()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.GetTotalPrice();
            }
            return total;
        }

        public void Checkout()
        {
            decimal total = GetTotalAmount();
            Console.WriteLine($"Your total amount is {total:C}. Proceeding to checkout...");
            Items.Clear();
        }
    }
}
