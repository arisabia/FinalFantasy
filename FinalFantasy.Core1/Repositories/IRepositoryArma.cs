using FinalFantasy.Core1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Repositories
{
    public interface IRepositoryArma : IRepository<Arma>
    {
        //per selezionare arma del personaggio
        public Arma GetByNome(string nome);
    }
}
