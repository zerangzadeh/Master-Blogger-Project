using MB.Domain.Models.CommentAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Mapping
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(x=>x.CommentID);
            builder.Property(x=>x.CommentText).IsRequired();
            builder.Property(x => x.UserName).IsRequired();
            builder.Property(x => x.Email);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CreationDate).IsRequired();
            builder.HasOne(x => x.Article).WithMany(x => x.Comments).HasForeignKey(x => x.ArticleID);


        }
    }
}
