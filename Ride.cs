using System;
using System.Collections.Generic;
using System.Text;

namespace Cap_Invoice
{
    public class Ride
    {
        public double distance;
        public int time;

        //intialize new instance
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
