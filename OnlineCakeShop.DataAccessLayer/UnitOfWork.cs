using OnlineCakeShop.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCakeShop.DataAccessLayer
{
	public class UnitOfWork : IDisposable
	{
		private readonly OnlineCakeShopDbContext _context;
	
		public UnitOfWork(OnlineCakeShopDbContext context)
		{
			_context = context;
			Users = new Repository<User>(context);
			Roles = new Repository<Role>(context);
		}

		public IRepository<User> Users { get; }
		public IRepository<Role> Roles { get; }

	

		public void Save()
		{
			_context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
