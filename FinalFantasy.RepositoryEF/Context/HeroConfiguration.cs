using FinalFantasy.Core1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF.Context
{
    public class HeroConfiguration : IEntityTypeConfiguration<Hero>
    {
        public void Configure(EntityTypeBuilder<Hero> builder)
        {
            builder.ToTable("Hero").HasKey(k => k.Nome);
            builder.Property(n => n.Nome).HasMaxLength(20);
            builder.Property(p => p.PuntiVita).IsRequired();
            builder.Property(l => l.Livello).IsRequired();

        }
    }
}
