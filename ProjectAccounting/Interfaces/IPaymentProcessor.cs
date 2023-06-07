using System;
using ProjectAccounting.Models;

namespace ProjectAccounting.Interfaces;

public interface IPaymentProcessor
{
    public IEnumerable<PaymentDone> RetrievePayments();

    public void ProcessPaymentForClient(int clientId);

    public IEnumerable<T> GetPaymentsByClient<T>(int clientId)
}

