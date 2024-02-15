using System;
using Microsoft.EntityFrameworkCore;
using MVC.Models.Entities;

namespace MVC.Models.Contexts
{
	public class DataContext:DbContext
	{
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer();
        //}

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }


        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}

