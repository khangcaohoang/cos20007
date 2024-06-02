namespace CustomProgram
{
    public class Program
    {
        public enum Category
        {
            Electronics,
            Games,
            Clothing
        }
        public static void Main(string[] args)
        {
                List<Product> electronics = new List<Product>
                {
                    new PhysicalProduct("E001", "Laptop", 1349.99m, 10, 2.5),
                    new PhysicalProduct("E002", "IPhone", 399.99m, 20, 0.5)
                };

                List<Product> games = new List<Product>
                {
                    new DigitalProduct("G001", "Video Game: Minecraft", 9.99m, 100, 5),
                    new DigitalProduct("G002", "Video Game: GTA:6", 129.99m, 80, 6)
                };

                List<Product> clothing = new List<Product>
                {
                    new PhysicalProduct("C001", "T-Shirt", 19.99m, 50, 0.2),
                    new PhysicalProduct("C002", "Pants", 39.99m, 30, 0.7)
                };

                User user = new User("U001", "Alice");

                bool shopping = true;

                while (shopping)
                {
                    Console.WriteLine("Select a category:");
                    Console.WriteLine("1. Electronics");
                    Console.WriteLine("2. Video Games");
                    Console.WriteLine("3. Clothing");
                    Console.WriteLine("4. View Cart");
       
                    Console.WriteLine("5. Checkout and Exit");

                    int categoryChoice = int.Parse(Console.ReadLine());
                    

                List<Product> selectedCategory = null;
                    string categoryName = "";

                    switch (categoryChoice)
                    {
                        case 1:
                            selectedCategory = electronics;
                            categoryName = "Electronics";
                            break;
                        case 2:
                            selectedCategory = games;
                            categoryName = "Games";
                            break;
                        case 3:
                            selectedCategory = clothing;
                            categoryName = "Clothing";
                            break;
                        case 4:
                            user.Cart.DisplayCart();
                            Console.WriteLine("1. Show item details?");
                            Console.WriteLine("2. Go Back");
                            int itemChoice = int.Parse(Console.ReadLine());
                            if (itemChoice == 2) continue;
                            if (itemChoice == 1)
                            {
                                Console.WriteLine("Enter the item number to view details:");
                                int itemIndex = int.Parse(Console.ReadLine()) - 1;
                                user.Cart.ViewDetails(itemIndex);
                                continue;
                            }
                            continue;
                        case 5:
                            user.Cart.Checkout();
                            shopping = false;
                            continue;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid category.");
                            continue;
                    }

                    Console.WriteLine($"Available {categoryName}:");
                    for (int i = 0; i < selectedCategory.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {selectedCategory[i].Name} - {selectedCategory[i].Price:C}");
                    }

                    Console.WriteLine("Select a product to add to cart (or 0 to go back):");
                    int productChoice = int.Parse(Console.ReadLine());

                    if (productChoice == 0) continue;

                    if (productChoice < 1 || productChoice > selectedCategory.Count)
                    {
                        Console.WriteLine("Invalid choice. Please select a valid product.");
                        continue;
                    }

                    Product selectedProduct = selectedCategory[productChoice - 1];

                    Console.WriteLine($"Enter quantity for {selectedProduct.Name}:");
                    int quantity = int.Parse(Console.ReadLine());

                    user.Cart.AddItem(selectedProduct, quantity);
                }
            }
        }
    }