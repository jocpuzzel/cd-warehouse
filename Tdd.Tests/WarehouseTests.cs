using NUnit.Framework;
using System.Collections.Generic;

namespace Tdd.Tests
{
    [TestFixture]
    public class WarehouseTests
    {
        private Warehouse _warehouse;

        [SetUp]
        public void SetUp()
        {
            IPaymentProvider paymentProvider = new PaymentProvider();

            _warehouse = new Warehouse(new List<CD>
            {
                new CD (paymentProvider, 2, "Safety Dance", "Men Without Hats")
            });
        }

        [Test]
        public void SearchOnTitle()
        {
            CD cd = _warehouse.FindByTitle("Safety Dance");

            Assert.AreEqual("Safety Dance", cd.Title);
        }

        [Test]
        public void SearchOnTitleNotFound()
        {
            CD cd = _warehouse.FindByTitle("Land Down Under");

            Assert.IsNull(cd);
        }

        [Test]
        public void SearchOnArtist()
        {
            CD cd = _warehouse.FindByArtist("Men Without Hats");

            Assert.AreEqual("Men Without Hats", cd.Artist);
        }

        [Test]
        public void SearchOnArtistNotFound()
        {
            CD cd = _warehouse.FindByArtist("Men With Hats");
            Assert.IsNull(cd);
        }
    }
}
