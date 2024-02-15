using Microsoft.EntityFrameworkCore;
using MVC.Models.Contexts;


internal class Program
{
    private static void Main(string[] args)
    {
        
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<DataContext>(cfg =>
        {
            cfg.UseSqlServer(builder.Configuration.GetConnectionString("cString"));
        });
        var app = builder.Build();
        app.MapDefaultControllerRoute();

        app.Run();
    }
}