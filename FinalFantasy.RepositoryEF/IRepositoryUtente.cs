using FinalFantasy.Core1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Repositories
{
    public interface IRepositoryUtente : IRepository<Utente>
    {
        public bool Add(Utente utente);
        public bool Delete(Utente utente);
    }
}
