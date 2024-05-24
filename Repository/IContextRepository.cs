using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contectsapi.Models;

namespace Contectsapi.Repository
{
    public interface IContactsRepository
    {
        Task Add(Contacts item);
        Task<IEnumerable<Contacts>> GetAll();
        Task<Contacts> Find(string key);
        Task Remove(string Id);
        Task Update(Contacts item);

        bool CheckValidUserKey(string reqkey);

    }
}