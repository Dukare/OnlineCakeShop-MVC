﻿using Microsoft.EntityFrameworkCore;
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
		public DbSet<Role> Roles { get; set; }
		public DbSet<User> Users { get; set; }
	
			protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			{
				optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=OnlineCakeShop;Trusted_Connection=True;");
			}
		
	}
}