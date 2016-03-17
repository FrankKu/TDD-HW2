using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class PotterShoppingCart
    {
        
        [TestMethod]
        public void CalcFee_第一集1本_第二集0本_第三集0本_第四集0本_第五集0本()
        {
            //Arrange
            var order = new List<Book>()
            {
                new Book() { EP = 1, Name = "哈利波特", SellPrice = 100 }
            };
            var target = new ShoppingCart();

            var expected = 100;
            //Act

            target.CalcFee(order);
            //Assert

            Assert.AreEqual(expected, target.TotalPrice);
        }

        [TestMethod]
        public void CalcFee_第一集1本_第二集1本_第三集0本_第四集0本_第五集0本()
        {
            //Arrange
            var order = new List<Book>()
            {
                new Book() { EP = 1, Name = "哈利波特", SellPrice = 100 },
                new Book() { EP = 2, Name = "哈利波特", SellPrice = 100 }
            };
            var target = new ShoppingCart();

            var expected = 190;
            //Act

            target.CalcFee(order);
            //Assert

            Assert.AreEqual(expected, target.TotalPrice);
        }
    }
}
