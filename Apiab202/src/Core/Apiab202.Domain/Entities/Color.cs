using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apiab202.Domain.Entities
{
	public class Color : NamedBaseEntity
	{
		public ICollection<ProductColor>? ProductColors { get; set; }
	}
}
