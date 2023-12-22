using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Apiab202.Application.ServiceRegistration
{
	public static class ServiceRegistration
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			//services.AddAutoMapper(typeof(CategoryProfile));
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			return services;
		}
	}
}
