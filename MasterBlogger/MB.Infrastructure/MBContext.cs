using MB.Domain.Model.ArticleCategoryAgg;
using MB.Domain.Models.ArticleAgg;
using MB.Domain.Models.CommentAgg;
using MB.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure
{


    public class MBContext : DbContext
    {
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public  DbSet<Comment> Comments { get; set; }

        public MBContext(DbContextOptions<MBContext> options) : base(options)
        {

        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            var assamblyArticleCategory = typeof(ArticleCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assamblyArticleCategory);
            base.OnModelCreating(modelBuilder);

            var assamblyArticleMapping = typeof(ArticleMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assamblyArticleMapping);
            base.OnModelCreating(modelBuilder);

            var assamblyCommentMapping = typeof(CommentMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assamblyArticleMapping);
            base.OnModelCreating(modelBuilder);



        }
    }

}
