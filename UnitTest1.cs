using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cap_Invoice;

namespace CapInvoiceTest
{
    [TestClass] 
    public class UnitTest1
    {
        [TestMethod]
        public void GiveDistanceAndTimeShouldRetuenTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            double expected = 17;
            double distance = 2.0;
            int time = 5;

            //calculateFare
            double fare = invoice.calculateFare(distance, time);

            Assert.AreEqual(expected, fare);
        }
        [TestMethod]
        public void GivenMultipleRidesShouldReturnTotalFare()
        {
            double expected = 47;
            //  creating instance of invoice generator
            InvoiceGenerator obj = new InvoiceGenerator(RideType.PREMIUM);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            // generating summary of all rides
            double actual = obj.Calculatefare(rides);

            Assert.AreEqual(actual, expected);
        }
    }
}
