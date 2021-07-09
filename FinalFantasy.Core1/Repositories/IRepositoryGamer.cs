using FinalFantasy.Core1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Repositories
{
    public interface IRepositoryGamer : IRepository<Gamer>
    {
        //registra Gamer
        public Gamer Add(Gamer gamer);
        //Per accedere 
        public Gamer GetByNickName(string nickName);
    }
}
