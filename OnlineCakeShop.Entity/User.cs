using System.Security.Principal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineCakeShop.DataAccessLayer
{
	public class User
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Int32 id { get; set; }

		[Required]
		[MaxLength(1000)]
		public string EmailId { get; set; }

		[Required]
		[MaxLength(100)]
		public string FirstName { get; set; }

		[Required]
		[MaxLength(100)]
		public string LastName { get; set; }

		public Boolean isActive { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateUpdated { get; set; }

		[Required]
		[MaxLength(2000)]
		public string PasswordHash { get; set; }

		[ForeignKey("Role")]
		public Int32 RoleID { get; set; }
	}
}