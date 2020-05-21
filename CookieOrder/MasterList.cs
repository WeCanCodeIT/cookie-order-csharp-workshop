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
    }
}
