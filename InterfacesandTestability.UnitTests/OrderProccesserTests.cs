using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InterfacesandTestability.UnitTests
{ //METHODNAME_CONDITION_EXPECTATION
    [TestClass]
    public class OrderProccesserTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()

        {
            var orderPrcoesser = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
              Shipment=new Shipment()
            };

            orderPrcoesser.Process(order);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()

        {
            var orderPrcoesser = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            orderPrcoesser.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1),order.Shipment.ShippingDate);


        }


        public class FakeShippingCalculator : IShippingCalculator
        {
            public float CalculateShipping(Order order)
            {
                return 1;
            }
        }
    }
}
