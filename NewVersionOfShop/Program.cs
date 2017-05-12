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
            //Sets exit value for main switch case to false
            bool exit = false;

            Console.WriteLine("##### Welcome to the second version of the store using LINQ #####");
            Console.WriteLine("Please Select what you would like to do: ");
            string mainInput= Console.ReadLine().ToUpper();
            char mainNav = mainInput[0];
            do
            {
                switch (mainNav)
                {
                    //Gives user option to add items into ItemStorage "warehouse"
                    case '1':
                        Console.WriteLine("1. Add items to the Warehouse.");
                        AddToWarehouse();
                        break;

                    //Gives user option to add items into ShopStorage "theShop"
                    case '2':
                        Console.WriteLine("2. Select Items from Warehouse to add into the Shop.");
                        AddToShop();
                        break;

                    //Enters the store
                    case '3':
                        Console.WriteLine("Enter the store.");
                        TheStore();
                        break;

                    //Exits the whole application by exiting the do-while loop
                    case '0':
                        exit = true;
                        break;

                    //Default case for invalid input
                    default:
                        Console.WriteLine("Oops! Wrong entry, try again.");
                        break;
                }
            } while (!exit);
        }
        private static void AddToWarehouse()
        { 
            //Method for adding things to ItemStorage "Warehouse"
        }

        private static void AddToShop()
        { 
            //Method for adding things to ShopStorage "theShop"
        }

        private static void TheStore()
        { 
            //Runs the store
        }
    }
}
