using MB.Application.Contracts.ArticleCategory;
using MB.Application.Services.ArticleCategoryApplication;
using MB.Domain.Services;
using MB.Infrastructure;
using MB.Infrastructure.Config;
using MB.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
BootStrapper.Config(builder.Services, builder.Configuration.GetConnectionString("MasterBloggerDB"));
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapDefaultControllerRoute();

app.Run();
