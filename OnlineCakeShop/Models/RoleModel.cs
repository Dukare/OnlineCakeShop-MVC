using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineCakeShop.Models
{
	public class RoleModel
	{
		[Key]
		[Required]
		[Range(1,10)]
		public Int32 RoleID { get; set; }

		[Required]
		[MaxLength(200)]
		[MinLength(5)]
		[DisplayName("Roll Name")]
		public string RollName { get; set; }
	}
}
