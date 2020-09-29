using System;

namespace NoISP
{
    public class CashOrder : IOrder
    {
        // This is the only method needed
        public void ProcessCashInvoice() { }

        public void ProcessCreditInvoice() { }

        public void ProcessOnlinePaymentInvoice() { }
    }
}