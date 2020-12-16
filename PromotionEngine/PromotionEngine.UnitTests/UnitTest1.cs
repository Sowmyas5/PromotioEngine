using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PromotionEngine;

namespace PromotionEngine.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        PromotionChecker.PromotionEngine promotionChecker;
       [TestMethod]
        public void TestMethod1()
        {
            PromotionChecker promotionChecker = new PromotionChecker();
            // Act
            try
            {
                List<Order> orders = new List<Order>();
                Order order1 = new Order(1, new List<Product>() { new Product("A"), new Product("A"), new Product("B"), new Product("B"), new Product("C"), new Product("D") });
                List<Promotion> promotions = new List<Promotion>()
                {
                     new Promotion(1, d1, 130),
                     new Promotion(2, d2, 45),
                     new Promotion(3, d3, 30)
                 };
                promotionChecker.GetTotalPrice(order1, promotions);
                Assert.AreEqual("Orders and the products", request.Status);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, UnitTest1.TestMethod1);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");

        }
    }
}
