using Microsoft.AspNetCore.Mvc;
using OnlineCakeShop.DataAccessLayer;
using OnlineCakeShop.Models;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace OnlineCakeShop.Controllers
{
    public class HomeController : BaseController
    {

		private readonly UnitOfWork _unitOfWork;
		private readonly ILogger<BaseController> _logger;
		public HomeController(UnitOfWork unitOfWork, ILogger<BaseController> logger) : base(unitOfWork, logger)
		{
            _unitOfWork=unitOfWork;
            _logger=logger;
		}

		public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Login(SignUpModel obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Users.Add(CreateUserFromSignUpObj(obj)) ;
                _unitOfWork.Save();

			}
            return View("Start");
        }
        private User CreateUserFromSignUpObj(SignUpModel obj)
        {
            return new User()
            {
                FirstName = obj.UserName,
                PasswordHash = GenerateHash(obj.Password),
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                isActive = true,
                RoleID = 1
            };
        }
		private  string GenerateHash(string password)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				// Compute hash from the password bytes
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

				// Convert byte array to a string representation
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2")); // Convert each byte to hexadecimal representation
				}
				return builder.ToString();
			}
		}
	}
}