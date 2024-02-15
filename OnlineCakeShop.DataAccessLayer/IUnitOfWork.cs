using OnlineCakeShop.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCakeShop.DataAccessLayer
{
	public interface IUnitOfWork : IDisposable
	{
		IUserRepository Users { get; }
		IRoleRepository Roles { get; }
		void Save();
	}
}
