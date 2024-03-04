using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCakeShop.DataAccessLayer
{
	public class OnlineCakeShopDbContext:DbContext
	{

		public OnlineCakeShopDbContext()
		{ }
		public OnlineCakeShopDbContext(DbContextOptions<OnlineCakeShopDbContext> options) : base(options)
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=OnlineCakeShop;Trusted_Connection=True;");
			optionsBuilder.UseSqlServer("Data Source=Shubham;Initial Catalog=OnlineCakeShop;Integrated Security=True;Trust Server Certificate=True");
		}
		public DbSet<Role> Roles { get; set; }
		public DbSet<User> Users { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Role>().HasData(
				new Role() {RoleID=1, RollName = "Admin" },
				new Role() {RoleID=2, RollName = "User" });
		}



	}
}
