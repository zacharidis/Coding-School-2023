using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Blazor.Shared.DTO.Admin
{
	public class AdminEditValidator : AbstractValidator<AdminEditDTO>
	{
		public AdminEditValidator()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Please enter a Name");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("Please enter a Surname");
			RuleFor(x => x.Username).NotEmpty().WithMessage("Please enter a Username");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Please enter a Password");
		}
	}
}
