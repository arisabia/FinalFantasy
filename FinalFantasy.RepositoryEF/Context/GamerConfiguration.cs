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
    public class GamerConfiguration : IEntityTypeConfiguration<Gamer>
    {
        public void Configure(EntityTypeBuilder<Gamer> builder)
        {
            builder.ToTable("Gamer");
            builder.HasKey(k => k.NickName);
            builder.HasMany(e => e.Heroes).WithOne(g => g.Gamer)
                                       .HasForeignKey(f => f.NickNameGamer);
        }
    }

}
