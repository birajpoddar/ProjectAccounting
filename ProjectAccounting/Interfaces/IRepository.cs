using System;
using ProjectAccounting.Models
namespace Repository;

public interface IRepository
{
    public IEnumerable<Client> GetClients();
    public Client GetClient(int clientId);

    
}

