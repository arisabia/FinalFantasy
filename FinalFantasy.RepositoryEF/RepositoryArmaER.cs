using FinalFantasy.Core1.Entities;
using FinalFantasy.Core1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF
{
    public class RepositoryArmaER : IRepositoryArma
    {
        public ICollection<Arma> GetAll()
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Armi.ToList();
            }
        }

        public Arma GetByNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
