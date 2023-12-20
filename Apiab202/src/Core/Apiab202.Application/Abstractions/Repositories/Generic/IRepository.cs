using Apiab202.Domain.Entitites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Apiab202.Application.Abstractions.Repositories
{
	public  interface IRepository<T> where T : BaseEntity,new()
	{
		IQueryable<T> GetAllAsync(Expression<Func<T, bool>>? expression = null, Expression<Func<T, object>>? orderExpression = null,
			bool isDesc = false,
			int skip = 0,
			int take = 0, bool isTracking = true,
			params string[] includes);

		Task<T> GetByIdAsync(int id);
		Task AddAsync(T item);
		void Update(T item);
		void Delete(T item);
		Task SaveChangesAsync();
	}
}
