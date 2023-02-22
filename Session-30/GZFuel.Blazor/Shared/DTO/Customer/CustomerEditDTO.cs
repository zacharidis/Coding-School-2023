using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Blazor.Shared.DTO.Customer
{
	public class CustomerEditDTO
	{

		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Surname { get; set; }
		public string CardNumber { get; set; }

		


	}
}
