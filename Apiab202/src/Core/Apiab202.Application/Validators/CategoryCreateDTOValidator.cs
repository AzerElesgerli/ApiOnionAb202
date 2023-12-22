using Apiab202.Application.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apiab202.Application.Validators
{
	internal class CategoryCreateDTOValidator:AbstractValidator<CategoryCreateDTO>

	{
		RuleFor(x=>x.Name).NotEmpty().Max

	}
}
