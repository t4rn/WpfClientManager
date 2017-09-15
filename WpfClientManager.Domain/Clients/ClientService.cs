using System;
using System.Collections.Generic;

namespace WpfClientManager.Domain.Clients
{
    public class ClientService
    {
        public ClientService()
        {

        }

        // TODO: query from SQLite
        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>()
            {
                 new Client() { Id = 1, Age = 10, FirstName = "a", LastName = "b", Email = "asd", BirthDate = new DateTime(2017, 12, 21) },
                 new Client() { Id = 2, Age = 23, FirstName = "c", LastName = "d", Email = "asd", BirthDate = new DateTime(2017, 6, 17) },
                 new Client() { Id = 3, Age = 34, FirstName = "e", LastName = "f", Email = "asd", BirthDate = new DateTime(2017, 8, 4) }
            };

            return clients;
        }
    }
}
