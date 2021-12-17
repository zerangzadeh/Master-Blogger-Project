using MB.Domain.Model.ArticleCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Mapping
{
    public class ArticleCategoryMapping:IEntityTypeConfiguration<ArticleCategory>
    {
      
     public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.ToTable("ArticleCategory");
            builder.HasKey(x=>x.CategoryID);
            builder.Property(x=>x.CategoryTitle).IsRequired();
            builder.Property(x=>x.CreationDate).IsRequired();
            builder.Property(x=>x.IsDeleted).IsRequired();
           
        }
    }
}
