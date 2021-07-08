using FinalFantasy.Core1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Repositories
{
    public interface IRepositoryPersonaggio : IRepository<Personaggio>
    {
        public bool Add(Personaggio personaggio);
        public bool Delete(Personaggio personaggio);
    }
}
