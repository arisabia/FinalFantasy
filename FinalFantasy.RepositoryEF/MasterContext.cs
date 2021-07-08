using FinalFantasy.Core1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF
{
    public class MasterContext :DbContext 
    {
        public DbSet<Level> Levels { get; set; }
        public DbSet<Personaggio> Personaggi { get; set; }
        public DbSet<Utente> Utenti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(@"Persist Security Info = False; Integrated Security = true; 
                                    Initial Catalog = FinalFantasy ; Server = .\SQLEXPRESS");
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Level>(new Context.LevelConfiguration());
            modelBuilder.ApplyConfiguration<Personaggio>(new Context.PersonaggioConfiguration());
            modelBuilder.ApplyConfiguration<Utente>(new Context.UtenteConfiguration());



        }


    }
    }
}
