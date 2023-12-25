using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apiab202.Application.Abstractions.Services
{
	internal class IProductServices
	{
		Task<IEnumerable<GetProductDTO>> GetAllAsync(int page, int limit);
	}
}
