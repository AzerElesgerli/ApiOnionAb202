using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apiab202.Application.DTOs.Product
{
	public record GetProductDTO(int Id, string Name, decimal Price, string SKU);
}
