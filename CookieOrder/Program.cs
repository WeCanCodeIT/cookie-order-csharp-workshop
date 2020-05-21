using System;

namespace CookieOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueOrdering = true;
            Order newOrder;
            MasterList masterCookieList = new MasterList();

            Console.WriteLine("Let's buy some cookies!");

            do
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Place Order");
                Console.WriteLine("2. Remove Order");
                Console.WriteLine("3. Review Master List of Orders");
                Console.WriteLine("4. See Details of an Order");
                Console.WriteLine("5. Apply Promotional Bonus to all Orders");
                Console.WriteLine("6. Exit Order Form");

                string menuOption = Console.ReadLine();
                Console.Clear();

                switch (menuOption)
                {
                    case "1":
                        // Add order
                        newOrder = new Order();
                        Console.Write("What is your name? ");
                        string name = Console.ReadLine();
                        newOrder.SetBuyer(name);
                        Console.Write("What cookie to you want to order? ");
                        newOrder.SetVariety(Console.ReadLine());
                        Console.Write("How many boxes would you like? ");
                        newOrder.SetNumberBoxes(Convert.ToInt32(Console.ReadLine()));
                        masterCookieList.AddOrder(newOrder);
                        break;
                    case "2":
                        // Remove order
                        break;
                    case "3":
                        // Review Master list
                        masterCookieList.PrintAllOrderDetails();
                        break;
                    case "4":
                        // See Order details
                        break;
                    case "5":
                        // Apply promotional bonus
                        break;
                    case "6":
                        Console.WriteLine("Thanks for shopping with us!  Good-bye.");
                        continueOrdering = false;
                        break;
                }
            } while (continueOrdering);
        }
    }
}
