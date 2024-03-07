using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
	public class OnlineCakeShopDbContext:IdentityDbContext
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
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);	
		}



	}
}
