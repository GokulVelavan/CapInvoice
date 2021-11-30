using System;
using System.Collections.Generic;
using System.Text;

namespace Cap_Invoice
{
    public class CabInvoiceException:Exception
    {
        public Exceptiontype type;
        public CabInvoiceException(Exceptiontype type, string message) : base(message)
        {
            this.type = type;
        }
        public enum Exceptiontype
        {
            INVALIDE_DISTANCE, INVALIDE_TIME, NULLRIDES, INVALID_USER_ID, INVALIDE_RIDETYPE, NULL_RIDES
        }
    }
}
