using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##### Welcome to the shop using LINQ!! #####");

            displayMainMenu();
            MainSelection();
           
        }

        private static void MainSelection()
        {
            while (true)
            {
                ItemStorage<Item> Warehouse = new ItemStorage<Item>();
                ShopStorage theStore = new ShopStorage();
                ShoppingCart Cart = new ShoppingCart();

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        Console.Clear();
                        foreach (var i in theStore.GetAllItems())
                        {
                            Console.WriteLine("\nName: " + i.Name +
                                              " | Article Number: " + i.ArtNum +
                                              " | Price: " + i.Price +
                                              " | Category: " + i.Category +
                                              " | In stock: " + i.InStock);
                        }
                        Console.ReadKey();
                        break;

                    case '2':
                        Console.Clear();
                        foreach (var i in theStore.GetItemsInStock())
                        {
                            Console.WriteLine("\nName: " + i.Name +
                                              " | Article Number: " + i.ArtNum +
                                              " | Price: " + i.Price +
                                              " | Category: " + i.Category +
                                              " | In stock: " + i.InStock);
                        }
                        Console.ReadKey();
                        break;
                    
                    case '3':
                        if (Cart.GetItemsInCart() == null)
                        {
                            Console.WriteLine("Your cart is empty!");
                        }
                        else
                        {
                            foreach (var i in Cart.GetItemsInCart())
                            {
                                Console.WriteLine("\nName: " + i.Name +
                                                  " | Article Number: " + i.ArtNum +
                                                  " | Price: " + i.Price +
                                                  " | Category: " + i.Category);
                            }
                        }
                        Console.ReadKey();
                        break;

                    case '0':
                        return;


                    default:
                        Console.WriteLine("Invalid entry, try again.");
                        break;
                }
            }
        }
        static void displayMainMenu()
        {
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("\n1. View all Items.");
            Console.WriteLine("2. View all items in stock.");
            Console.WriteLine("3. View Items in cart.");
            Console.WriteLine("4. Checkout.");
            Console.WriteLine("0. Exit.");
        }
    }
}
