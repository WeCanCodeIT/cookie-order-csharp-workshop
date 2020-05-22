using System;
using System.Collections.Generic;
using System.Text;

namespace CookieOrder
{
    public class MasterList
    {
        public List<Order> CookieOrderList = new List<Order>();

        public void AddOrder(Order order)
        {
            CookieOrderList.Add(order);
        }

        public void PrintAllOrderDetails()
        {
            Console.WriteLine("Master List of Cookie Orders: ");
            foreach(Order order in CookieOrderList)
            {
                order.PrintOrderDetails();
            }
        }

        public void PrintAllBuyers()
        {
            // Print all buyers with a number assigned
            int listNumber = 1;

            Console.WriteLine("List of Buyers: ");
            foreach(Order order in CookieOrderList)
            {
                string buyer = order.GetBuyer();
                Console.WriteLine($"{listNumber}. {buyer}");
                listNumber++;
            }
        }

        public Order FindCookieOrderByIndex(int index)
        {

            Order selectedOrder = CookieOrderList[index];
            return selectedOrder;
        }

        public void RemoveOrderFromList(Order order)
        {
            CookieOrderList.Remove(order);
        }
    }
}
