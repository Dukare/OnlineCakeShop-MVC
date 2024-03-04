using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineCakeShop.Models
{
	public class SignUpModel
	{
		[Required]
		[MaxLength(50)]
		[MinLength(5)]
		
		public string UserName { get; set; }

		[Required]
		[MaxLength(100)]
	
		public string Email { get; set; }

		[Required]
		[MaxLength(100)]
		[MinLength(6)]
	
		public string Password { get; set; }
	}
}
