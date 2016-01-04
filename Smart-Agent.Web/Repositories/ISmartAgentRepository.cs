using Smart_Agent.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Agent.Web.Repositories
{
    public interface ISmartAgentRepository
    {
        Task Add(Client item);
        Task<IEnumerable<Client>> GetAll();
        Client Find(Guid clientKey);
        Client Remove(Guid clientKey);
        Task Update(Client client);
    }
}
