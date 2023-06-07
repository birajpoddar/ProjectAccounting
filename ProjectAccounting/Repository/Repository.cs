using System;
using ProjectAccounting.Models;
using Repository;

namespace ProjectAccounting.Repository;

public class AccountingRepository : IRepository
{
	public AccountingRepository()
	{
	}

    public Client GetClient(int clientId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Client> GetClients()
    {
        throw new NotImplementedException();
    }
}

