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
        public DbSet<Gamer> Gamers { get; set; }
        public DbSet<Personaggio> Personaggi { get; set; }
        public DbSet<Arma> Armi { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Hero> Heroes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(@"Persist Security Info = False; Integrated Security = true; 
                                    Initial Catalog = FinalFantasy ; Server = .\SQLEXPRESS");
        }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Gamer>(new Context.GamerConfiguration());
            modelBuilder.ApplyConfiguration<Personaggio>(new Context.PersonaggioConfiguration());
            modelBuilder.ApplyConfiguration<Arma>(new Context.ArmaConfiguration());
            modelBuilder.ApplyConfiguration<Hero>(new Context.HeroConfiguration());
            modelBuilder.ApplyConfiguration<Monster>(new Context.MonsterConfiguration());

        }


    }
    }

