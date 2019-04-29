using System;
using System.Collections.Generic;
using System.Text;
using BlogEFSqt.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogEFSqt.Infrastructure.Database.EntityConfigurations
{
   public  class BlogConfiguration: IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(x => x.Remark).HasMaxLength(200);
        }
    }
}
