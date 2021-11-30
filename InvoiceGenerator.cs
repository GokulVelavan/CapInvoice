using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Cap_Invoice
{
    public class InvoiceGenerator
    {
        RideType rideType;
        //Constants
        private readonly double MINIMUM_COST_PER_KM;
        private readonly int COST_PER_TIME;
        private readonly double MINIMUM_FARE;

    
        public InvoiceGenerator(RideType rideType)
        {
            this.rideType = rideType;
            try
            {
                if (this.rideType.Equals(RideType.NORMAL))
                {
                    this.MINIMUM_COST_PER_KM = 10;
                    this.COST_PER_TIME = 1;
                    this.MINIMUM_FARE = 5;
                }

                if (this.rideType.Equals(RideType.PREMIUM))
                {
                    this.MINIMUM_COST_PER_KM = 15;
                    this.COST_PER_TIME = 2;
                    this.MINIMUM_FARE = 20;
                }
            }
            catch
            {
                throw new CabInvoiceException(CabInvoiceException.Exceptiontype.INVALIDE_RIDETYPE, "Invalid Ride Type");
            }
        }

        public double calculateFare(double distance, int time)
        {
            double totalFare = 0;
            try
            {
                totalFare = distance + MINIMUM_COST_PER_KM + (time * COST_PER_TIME);
            }
            catch
            {
                if (distance <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.Exceptiontype.INVALIDE_DISTANCE, "Invalid Distance");
                }
                if (time <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.Exceptiontype.INVALIDE_TIME, "Invalid Time");
                }
            }
            return Math.Max(totalFare, MINIMUM_FARE);
        }

        public double Calculatefare(Ride[] rides)
        {
            double totalFare = 0;
            try
            {
                // calculating total fare
                foreach (Ride ride in rides)
                {
                    totalFare += this.calculateFare(ride.distance, ride.time);
                }
            }
            catch (CabInvoiceException)
            {
                if (rides == null)
                {
                    throw new CabInvoiceException(CabInvoiceException.Exceptiontype.NULLRIDES, "no rides found");
                }
            }
            return totalFare;
        }

    }
}
