using System;
using Xunit;

namespace CookieOrder.Tests
{
    public class OrderTests
    {
        Order sut; //system under test

        public OrderTests()
        {
            sut = new Order();
        }
        
        // Sets buyer
        [Fact]
        public void SetBuyer_Should_Set_Buyer_Property()
        {
            string buyer = "Cookie Monster";

            sut.SetBuyer(buyer);

            Assert.Equal(buyer, sut.Buyer);
        }

        // Set variety
        [Fact]
        public void SetVariety_Should_Set_Variety_Property()
        {
            string variety = "Thin Mints";

            sut.SetVariety(variety);

            Assert.Equal(variety, sut.Variety);
        }


        // Set number of boxes
        [Fact]
        public void SetNumberBoxes_Should_Set_NumberBoxes_Property()
        {
            int numberOfBoxes = 10;

            sut.SetNumberBoxes(numberOfBoxes);

            Assert.Equal(numberOfBoxes, sut.NumberBoxes);
        }

    }
}
