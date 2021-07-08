using FinalFantasy.Core1.Entities;
using FinalFantasy.Core1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF
{
    public class RepositoryLevelEF : IRepositoryLevel
    {
        public ICollection<Level> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
