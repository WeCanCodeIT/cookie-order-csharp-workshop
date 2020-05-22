using System;
using System.Collections.Generic;
using System.Net;
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

        // Find the cookie order and return to caller
        [Fact]
        public void FindCookieOrderInList_Should_Return_Correct_Cookie_Object()
        {
            // Arrange
            Order orderToRemove = new Order();
            sut.AddOrder(orderToRemove);
            int myCookieIndex = sut.CookieOrderList.IndexOf(orderToRemove);

            // Act
            Order returnedFromList = sut.FindCookieOrderByIndex(myCookieIndex);

            // Assert
            Assert.True(orderToRemove.Equals(returnedFromList));
        }

        [Fact]
        public void RemoveOrder_Should_Remove_Order_FromList()
        {
            Order order = new Order();
            sut.AddOrder(order);

            sut.RemoveOrderFromList(order);

            Assert.DoesNotContain(order, sut.CookieOrderList);
        }

        [Fact]
        public void AddFreeBoxToAllOrders_Should_Increase_Box_Count_Of_All_Orders()
        {
            // Arrange
            Order firstOrder = new Order();
            firstOrder.SetNumberBoxes(10);
            sut.AddOrder(firstOrder);

            Order secondOrder = new Order();
            secondOrder.SetNumberBoxes(10);
            sut.AddOrder(secondOrder);

            // Act
            sut.AddFreeBoxToAllOrders();

            // Assert with 2 Assertions, not best practice
            Assert.Equal(11, firstOrder.NumberBoxes);
            Assert.Equal(11, secondOrder.NumberBoxes);

            // Example of single assertion to pass this test
            // Assert.True(sut.CookieOrderList.TrueForAll(order => order.NumberBoxes == 11));
        }


    }
}
