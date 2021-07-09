using FinalFantasy.Core1.Entities;
using FinalFantasy.Core1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF
{
    public class RepositoryGamerER : IRepositoryGamer
    {
        public  Gamer Add(Gamer gamer)
        {
            using (var ctx = new MasterContext())
            {

            
            if (gamer != null)
            {
                    try
                    {
                        ctx.Gamers.Add(gamer);
                       ctx.SaveChanges();
                        return gamer;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex);
                    }                          
            }
            }
            return null;
        }

        public ICollection<Gamer> GetAll()
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Gamers.ToList();
            }
        }

        public Gamer GetByNickName(string nickName)
        {
            throw new NotImplementedException();
        }
    }
}
