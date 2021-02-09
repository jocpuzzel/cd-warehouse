using NUnit.Framework;
using System;

namespace Tdd.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BuyACDPaymentAccepted()
        {
            IPaymentProvider paymentProvider = new PaymentProvider();

            CD cd = new CD(paymentProvider, 2);

            cd.Buy();

            Assert.AreEqual(1, cd.StockAmount);
        }
    }

    internal class PaymentProvider : IPaymentProvider
    {
        public bool WasPaymentSuccessful()
        {
            return true;
        }
    }

    internal interface IPaymentProvider
    {
        bool WasPaymentSuccessful();
    }

    internal class CD
    {
        public CD(IPaymentProvider paymentProvider, int stockAmount)
        {
            StockAmount = stockAmount;
        }

        public int StockAmount { get; set; }

        internal void Buy()
        {
            StockAmount--;
        }
    }
}