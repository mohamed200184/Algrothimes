namespace E_CommerceShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            bool running = true;
            while (running) 
            {
                Console.WriteLine("\n E-Commerce Shopping Cart");
                Console.WriteLine("1.Add Item to Cart ");
                Console.WriteLine("2.Display Items ");
                Console.WriteLine("3. Sort by Price ");
                Console.WriteLine("4. Sort by Name");
                Console.WriteLine("5. Calculate Total Cost");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option (1-6): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("enter item name : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("enter item price ");
                        decimal price =decimal.Parse(Console.ReadLine());
                        Console.WriteLine("enter item quanutity");
                        int quantity = int.Parse(Console.ReadLine());
                        cart.AddItem(name, price, quantity);
                        break;
                    case "2":
                        cart.DisplayItems();
                        break;
                    case "3":
                        cart.sortbyPrice();
                        Console.WriteLine("items sorted by price");
                        cart.DisplayItems(); 
                        break;
                    case "4":
                        cart.sortByName();
                        Console.WriteLine("items sorted by Name");
                        cart.DisplayItems();
                        break;
                    case "5":
                        Console.WriteLine($"Total Cost :{cart.CalculateTotalPrice():c}");
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Exting ...");
                        break;
                    default:
                        Console.WriteLine("invalid option .... please try agine");
                        break ;

                }

            }
        }
    }
}
