using MB.Application.Contracts.Article;
using MB.Application.Contracts.ArticleCategory;
using MB.Application.Contracts.Comment;
using MB.Application.Services.ArticleApplication;
using MB.Application.Services.ArticleCategoryApplication;
using MB.Application.Services.CommentApplication;
using MB.Domain.Models.ArticleAgg;
using MB.Domain.Models.ArticleAgg.Services;
using MB.Domain.Models.ArticleCategoryAgg;
using MB.Domain.Models.ArticleCategoryAgg.Services;
using MB.Domain.Models.CommentAgg;
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
           // service.AddTransient<IArticleCategoryValidatorService,ArticleCategoryValidatorService>();
           // service.AddTransient<IArticleCValidatorService, ArticleValidatorService>();
            service.AddTransient<IArticleRepository, ArticleRepository>();
            service.AddTransient<IArticleApplication, ArticleApplication>();
            service.AddTransient<ICommentRepository, CommentRepository>();
            service.AddTransient<ICommentApplication, CommentApplication>();
            service.AddDbContext<MBContext>(x=>x.UseSqlServer(connectionString));
        }
    }
}