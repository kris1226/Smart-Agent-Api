using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Smart_Agent.Web.Models;
using System.Threading.Tasks;

namespace Smart_Agent.Web.Repositories
{
    public class SmartAgentRepository : ISmartAgentRepository
    {
        public Task Add(Client item)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Client>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Client Find(Guid clientKey)
        {
            throw new NotImplementedException();
        }

        public Client Remove(Guid clientKey)
        {
            throw new NotImplementedException();
        }

        public Task Update(Client client)
        {
            throw new NotImplementedException();
        }
    }
}