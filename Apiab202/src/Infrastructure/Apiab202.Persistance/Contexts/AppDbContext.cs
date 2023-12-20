using Apiab202.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apiab202.Persistance.Contexts
{
	internal class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Color> Colors { get; set; }
		public DbSet<ProductColor> ProductColors { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().Property(c => c.Name).IsRequired().HasMaxLength(166) ;
			
			modelBuilder.Entity<Product>().Property(c => c.Name).IsRequired().HasMaxLength(166);
			modelBuilder.Entity<Product>().Property(c => c.Price).IsRequired().HasColumnType("decimal(6,2)");
			modelBuilder.Entity<Product>().Property(c => c.Description).IsRequired(false).HasColumnType("text");
			modelBuilder.Entity<Product>().Property(c => c.SKU).IsRequired().HasMaxLength(166);





			base.OnModelCreating(modelBuilder);
		}
	}
}
