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
    }
}
