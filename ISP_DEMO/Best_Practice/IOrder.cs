using System;

namespace ISP
{
    // Now you can use this either for a common functionality
    // Or to include all of them. 
    // Now I am going to use it to do the second option
    public interface IOrder : ICashOrder, ICreditOrder, IOnlinePaymentOrder, IInstallmentOrder
    {
        // Also, you can include any additional methods regrading order only.
    }

    public interface ICashOrder
    {
        void ProcessCashInvoice();
    }

    public interface ICreditOrder
    {
        void ProcessCreditInvoice();
    }

    public interface IOnlinePaymentOrder
    {
        void ProcessOnlinePaymentInvoice();
    }

    public interface IInstallmentOrder
    {
        void ProcessInstallmentInvoice();
    }
}