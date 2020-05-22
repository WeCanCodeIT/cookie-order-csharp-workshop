using System;
using System.Collections.Generic;
using System.Text;

namespace CookieOrder
{
    public class Order
    {
        public string Buyer { get; set; }
        public string Variety { get; set; }
        public int NumberBoxes { get; set; }

        public void SetBuyer(string buyer)
        {
            Buyer = buyer;
        }

        public string GetBuyer()
        {
            return Buyer;
        }

        public void SetVariety(string variety)
        {
            Variety = variety;
        }

        public void SetNumberBoxes(int number)
        {
            NumberBoxes = number;
        }

        public void PrintOrderDetails()
        {
            Console.WriteLine($"BUYER: {Buyer}");
            Console.WriteLine($"VARIETY: {Variety}");
            Console.WriteLine($"NUM OF BOXES: {NumberBoxes}\n");
        }

        public void AddFreeBox()
        {
            NumberBoxes++;
        }
    }
}
