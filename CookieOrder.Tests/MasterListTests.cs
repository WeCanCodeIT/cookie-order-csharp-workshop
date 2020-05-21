using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CookieOrder.Tests
{
    public class MasterListTests
    {
        MasterList sut;

        public MasterListTests()
        {
            sut = new MasterList();
        }

        // AddOrder
        [Fact]
        public void AddOrder_Should_Increase_List_Count_To_1() 
        {
            Order newOrder = new Order();
            
            sut.AddOrder(newOrder);
            
            Assert.Single(sut.CookieOrderList);
        }

    }
}
