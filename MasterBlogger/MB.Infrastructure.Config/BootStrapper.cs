using MB.Application.Contracts.ArticleCategory;
using MB.Application.Services.ArticleCategoryApplication;
using MB.Domain.Models.ArticleCategoryAgg;
using MB.Domain.Models.ArticleCategoryAgg.Services;
using MB.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure.Config
{
    public class BootStrapper
    {
        public static void Config(IServiceCollection service, string connectionString)
        {
            service.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            service.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            service.AddTransient<IArticleCategoryValidatorService,ArticleCategoryValidatorService>();
            service.AddDbContext<MBContext>(x=>x.UseSqlServer(connectionString));
        }
    }
}