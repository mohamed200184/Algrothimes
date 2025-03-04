using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceShoppingCart
{
    public class ShoppingCart
    {
        private List<Item> items = new List<Item>();

        public void AddItem(string name, decimal price, int quantity)
        {
            items.Add(new Item(name, price, quantity));
        }


        public void DisplayItems()
        {
            Console.WriteLine("\n Items in cart");
            Console.WriteLine("Name\t\tprice\tQuantity");
            Console.WriteLine("------------------------");
            foreach (var Item in items)
            {
                Console.WriteLine($"{Item.Name}\t\t{Item.Price}\t\t{Item.Quantity}");
            }
        }


        public decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var Item in items)
            {
                total += Item.Price * Item.Quantity;
            }
            return total;
        }

        //sort items by price 
        public void sortbyPrice()
        {
            for(int i=1; i < items.Count; i++)
            {
                Item key = items[i];
                int j = i - 1;
                while (j >= 0 && items[j].Price > key.Price)
                {
                    items[j + 1] = items[j];
                    j--;
                }
                items[j+1]=key;
            }
        }

        //sort items by name
        public void sortByName()
        {
            for (int i = 1; i < items.Count; i++)
            {
                Item key = items[i];
                int j = i - 1;
                while (j >= 0 && string.Compare(items[j].Name , key.Name)>0)
                {
                    items[j + 1] = items[j];
                    j--;
                }
                items[j + 1] = key;
            }
        }
    }
}
