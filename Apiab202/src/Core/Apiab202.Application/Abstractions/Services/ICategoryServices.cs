using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apiab202.Application.Abstractions.Services
{
	internal interface ICategoryServices
	{
		Task<ICollection<GetCategoryDTO>> GetAllAsync(int page, int limit);
		
		Task CreateAsync(CreateCategoryDTO categoryDTO);
		Task UpdateAsync(int id, UpdateCategoryDTO categoryDTO);
		Task DeleteAsync(int id);
		Task SoftDeleteAsync(int id);
	}
}
