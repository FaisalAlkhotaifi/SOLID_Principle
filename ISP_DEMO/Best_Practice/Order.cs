using System;

namespace ISP
{
    public class Order : IOrder
    {
        public void ProcessCashInvoice() {}

        public void ProcessCreditInvoice() {}

        public void ProcessInstallmentInvoice() {}

        public void ProcessOnlinePaymentInvoice() { }
    }
}