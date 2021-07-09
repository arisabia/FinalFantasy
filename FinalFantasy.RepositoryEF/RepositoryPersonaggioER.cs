using FinalFantasy.Core1.Entities;
using FinalFantasy.Core1.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF
{
    public class RepositoryPersonaggioER : IRepositoryPersonaggio
    {
        public Personaggio Add(Personaggio personaggio)
        {
            using (var ctx = new MasterContext())
            {


                if (personaggio != null)
                {
                    try
                    {
                        ctx.Personaggi.Add(personaggio);
                        ctx.SaveChanges();
                        return personaggio;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex);
                    }
                }
            }
            return null;
        }

        public bool Delete(Personaggio personaggio)
        {
            using (var ctx = new MasterContext())
            {
                if (personaggio != null)
                {
                    ctx.Entry<Personaggio>(personaggio).State = EntityState.Deleted;
                    ctx.SaveChanges();
                    return true;

                }
                return false;
            }
        }

        public ICollection<Personaggio> GetAll()
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Personaggi.ToList();
            }
        }

        //public Personaggio GetByNome(string nome)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
