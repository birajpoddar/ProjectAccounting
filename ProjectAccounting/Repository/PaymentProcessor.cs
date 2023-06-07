using System;
using ProjectAccounting.Interfaces;
using ProjectAccounting.Models;

namespace ProjectAccounting.Repository
{
    public class PaymentProcessor : IPaymentProcessor
    {


        public PaymentProcessor()
        {
        }

        public IEnumerable<T> GetPaymentsByClient<T>(int clientId)
        {
            throw new NotImplementedException();
        }

        public void ProcessPaymentForClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public async void RetrievePayments()
        {
            await throw new NotImplementedException();
        }

        IEnumerable<PaymentDone> IPaymentProcessor.RetrievePayments()
        {
            throw new NotImplementedException();
        }
    }
}

