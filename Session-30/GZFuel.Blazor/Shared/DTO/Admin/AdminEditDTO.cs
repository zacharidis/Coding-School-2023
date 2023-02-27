using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Blazor.Shared.DTO.Admin
{
    public class AdminEditDTO
    {
        public int Id { get; set; }
       
		[Required(ErrorMessage = "Please enter a Name")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Please enter a Surname")]
		public string Surname { get; set; }
		
		[Required(ErrorMessage = "Please enter a Username")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Please enter a Password")]
		public string Password { get; set; }
		
	}
}
