using System;

namespace NoISP
{
    public interface IOrder 
    {
        void ProcessCashInvoice();
        void ProcessCreditInvoice();
        void ProcessOnlinePaymentInvoice();
    }
}