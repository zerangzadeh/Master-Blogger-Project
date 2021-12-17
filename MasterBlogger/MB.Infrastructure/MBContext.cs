using MB.Domain.Model.ArticleCategoryAgg;
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

        public MBContext(DbContextOptions<MBContext> options) : base(options)
            {

            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            var assambly = typeof(ArticleCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assambly);
            base.OnModelCreating(modelBuilder);



        }
    }
    
}
