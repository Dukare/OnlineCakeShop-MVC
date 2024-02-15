using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCakeShop.DataAccessLayer.Repository
{
	public class RoleRepository : Repository<Role>, IRoleRepository
	{
		public RoleRepository(OnlineCakeShopDbContext context) : base(context)
		{
		}
	}
}
