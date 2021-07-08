using FinalFantasy.Core1.Entities;
using FinalFantasy.Core1.Repositories;
using System;
using System.Collections.Generic;

namespace FinalFantasy.RepositoryEF
{
    public class RepositoryPersonaggioEF : IRepositoryPersonaggio
    {
        public bool Add(Personaggio personaggio)
        {
            bool esito = false;
            using (var ctx = new MasterContext())
            {
                if (Personaggio != null)
                {
                    try
                    {
                        ctx.Teachers.Add(personaggio);
                        ctx.SaveChanges();
                        esito = true;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex);
                    }
                }

            }
            return esito;
        }

        public bool Delete(Personaggio personaggio)
        {
            throw new NotImplementedException();
        }

        public ICollection<Personaggio> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
