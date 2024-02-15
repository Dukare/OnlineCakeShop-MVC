using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCakeShop.DataAccessLayer.Repository
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		private readonly OnlineCakeShopDbContext _context;
		private readonly DbSet<TEntity> _set;

		public Repository(OnlineCakeShopDbContext context)
		{
			_context = context;
			_set = context.Set<TEntity>();
		}

		public TEntity GetById(int id)
		{
			return _set.Find(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _set.ToList();
		}

		public void Add(TEntity entity)
		{
			_set.Add(entity);
		}

		public void Update(TEntity entity)
		{
			_set.Attach(entity);
			_context.Entry(entity).State = EntityState.Modified;
		}

		public void Delete(TEntity entity)
		{
			_set.Remove(entity);
		}
	}

}
