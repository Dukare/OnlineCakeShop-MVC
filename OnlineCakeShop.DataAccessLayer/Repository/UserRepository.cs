using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCakeShop.DataAccessLayer.Repository
{
	public class UserRepository : Repository<User>, IUserRepository
	{
		public UserRepository(OnlineCakeShopDbContext context) : base(context)
		{
		}
	}
}
