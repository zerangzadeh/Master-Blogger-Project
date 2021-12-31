using AutoMapper;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.Model.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Config
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ArticleCategory, ArticleCategoryViewModel>().ReverseMap();
        }
    }
}
