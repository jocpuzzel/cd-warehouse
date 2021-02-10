using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tdd.Tests
{
    public class CDTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void BuyInStockCD()
        {
            IPaymentProvider paymentProvider = new PaymentProvider();

            CD cd = new CD(paymentProvider, 2, "", "");

            cd.Buy();

            Assert.AreEqual(1, cd.StockAmount);
        }

        [Test]
        public void BuyOutOfStockCD()
        {
            IPaymentProvider paymentProvider = new PaymentProvider();

            var cd = new CD(paymentProvider, 0, "", "");

            cd.Buy();

            Assert.AreEqual(0, cd.StockAmount);
        }
    }
}