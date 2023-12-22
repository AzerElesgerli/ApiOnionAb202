using Apiab202.Application.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apiab202.Application.MappingProfiles
{
	
		internal class CategoryProfile : Profile
		{
			public CategoryProfile()
			{
				CreateMap<Category, CategoryItemDto>().ReverseMap();
				CreateMap<CategoryCreateDto, Category>();

			}
		}
	}
}
