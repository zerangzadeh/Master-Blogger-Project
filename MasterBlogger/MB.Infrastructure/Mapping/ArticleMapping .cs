using MB.Domain.Model.ArticleCategoryAgg;
using MB.Domain.Models.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
      
          public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");
            builder.HasKey(x => x.ArticleID);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x=>x.ShortDESC).IsRequired();
            builder.Property(x=>x.Body).IsRequired();
            builder.Property(x => x.PicTitle);
            builder.Property(x => x.PicALT);
            builder.HasKey(x => x.PicSrc);
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.CreationDate).IsRequired();
            builder.HasOne(x => x.ArticleCategory).WithMany(x => x.Articles).HasForeignKey(x=>x.CategoryID);

        }
    }
}
