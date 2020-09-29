using System;

namespace NoISP
{
    public class OnlineOrder : IOrder
    {
        public void ProcessCashInvoice() { }

        public void ProcessCreditInvoice() { }

        // This is the only method needed
        public void ProcessOnlinePaymentInvoice() { }
    }
}