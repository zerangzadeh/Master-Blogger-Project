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
        public ArticleCategoryMapping()
        {
        }

        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.ToTable("ArticleCategories");
            builder.HasKey(x=>x.CategoryID);
            builder.Property(x=>x.Title).IsRequired();
            builder.Property(x=>x.CreationDate).IsRequired();
            builder.Property(x=>x.IsDeleted).IsRequired();
            builder.HasMany(x => x.Articles).WithOne(x => x.ArticleCategory);
        }
    }
}
