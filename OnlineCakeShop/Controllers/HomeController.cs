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
        
	}
}