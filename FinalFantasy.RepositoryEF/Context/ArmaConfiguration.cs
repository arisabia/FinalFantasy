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
    public class ArmaConfiguration : IEntityTypeConfiguration<Arma>
    {
        public void Configure(EntityTypeBuilder<Arma> builder)
        {
            builder.ToTable("Arma");
            builder.HasKey(k => k.Nome);
            builder.Property(pd => pd.PuntiDanno).IsRequired();
        }
    }
}
