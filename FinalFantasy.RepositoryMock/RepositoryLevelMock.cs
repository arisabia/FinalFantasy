using FinalFantasy.Core1.Entities;
using FinalFantasy.Core1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryMock
{
    public class RepositoryLevelMock : IRepositoryLevel
    {
        private ICollection<Level> Levels = new List<Level>
        {
            new Level
        };



        public ICollection<Level> GetAll()
        {
            throw new NotImplementedException();
        }

       
    }
}
