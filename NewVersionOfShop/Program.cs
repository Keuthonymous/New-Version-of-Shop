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

            //Displays main menu
            displayMainMenu();

            //Runs switch case for inputs
            MainSelection();
           
        }

        private static void MainSelection()
        {
            while (true)
            {
                //Instantiates new ItemStorage, ShopStorage, and ShoppingCart
                ItemStorage<Item> Warehouse = new ItemStorage<Item>();
                ShopStorage theStore = new ShopStorage();
                ShoppingCart Cart = new ShoppingCart();

                //Switch case for main functions
                switch (Console.ReadKey().KeyChar)
                {
                    //Displays all items in ItemStorage, known as Warehouse
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
                       
                    //Displays all items in ShopStorage known as theStore
                    case '2':
                        Console.Clear();
                        foreach (var i in theStore.GetItemsInStock())
                        {
                            Console.WriteLine("\nName: " + i.Name +
                                              " | Article Number: " + i.ArtNum +
                                              " | Price: " + i.Price +
                                              " | Category: " + i.Category +
                                              " | In stock: " + i.InStock);

                            Console.WriteLine("Would you like to add items to your cart? (Y/N)");
                            AddToCart();
                        }
                        Console.ReadKey();
                        break;
                    
                    //Displays items in Shopping cart as long as it is not empty
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

                    //Exit case
                    case '0':
                        return;

                    //Default case
                    default:
                        Console.WriteLine("Invalid entry, try again.");
                        break;
                }
            }
        }

        private static void AddToCart()
        {
            string input;
            input = Console.ReadLine();
            char nav = input[0];
            Char.ToUpper(nav);

            switch (nav)
            { 
                case 'Y':

                    break;
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
