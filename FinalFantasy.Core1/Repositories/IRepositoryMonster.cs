using FinalFantasy.Core1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Repositories
{
    public interface IRepositoryMonster : IRepository<Monster>
    {
        public Monster GetById(int id);

        public IList<Monster> GetMonsterByLevel(int livello);
    }
}
