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
         
            InvoiceGenerator obj = new InvoiceGenerator(RideType.PREMIUM);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
       
            double actual = obj.Calculatefare(rides);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            
      
            InvoiceGenerator obj = new InvoiceGenerator(RideType.PREMIUM);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            InvoiceSummary expected = new InvoiceSummary(rides.Length, 47);
   
            InvoiceSummary actual = obj.Calculate_Fare(rides);

            //actual.Equals(expected);
            Assert.AreEqual(actual, expected);
        }
    }
}
