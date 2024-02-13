using System.Security.Principal;

namespace OnlineCakeShop.DataAccessLayer
{
	public class User
	{
		
		public int id { get; set; }
		public string EmailId { get; set; }
		public string FirstName { get; set; }
		public string lastName { get; set; }

		public Boolean isActive { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateUpdated { get; set; }
		public string PasswordHash { get; set; }

		public int RoleID { get; set; }
	}
}