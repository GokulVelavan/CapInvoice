using System;
using System.Collections.Generic;
using System.Text;

namespace Cap_Invoice
{
    public class InvoiceSummary
    {
        private int numberOfRides;
        private double totalFare;
        private double averageFare;

        public InvoiceSummary(int numberOfRides, double totalFare)  //here Enhanced Invoice
        {
            this.numberOfRides = numberOfRides; 
            this.totalFare = totalFare;       
            this.averageFare = totalFare / numberOfRides; 
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is InvoiceSummary))
            {
                return false;
            }
            InvoiceSummary summary = (InvoiceSummary)obj;
            return this.numberOfRides == summary.numberOfRides && this.totalFare == summary.totalFare && this.averageFare == summary.averageFare;

        }
    }
}
