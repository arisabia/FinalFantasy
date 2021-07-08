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
    public class PersonaggioConfiguration : IEntityTypeConfiguration<Personaggio>
    {
        public void Configure(EntityTypeBuilder<Personaggio> builder)
        {
            builder.ToTable("Personaggio").HasKey(k => k.Nome);
            builder.Property(n => n.Nome).HasMaxLength(20);

            builder.HasDiscriminator<string>("personnagio_type")
                .HasValue<Monster>("monster")
                .HasValue<Hero>("hero");
        }
    }
}
