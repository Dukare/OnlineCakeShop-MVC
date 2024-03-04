using Microsoft.AspNetCore.Mvc;
using OnlineCakeShop.DataAccessLayer;

namespace OnlineCakeShop.Controllers
{
	public class BaseController : Controller
	{
        private readonly UnitOfWork _unitOfWork;
		private readonly ILogger<BaseController> _logger;
		public BaseController(UnitOfWork unitOfWork, ILogger<BaseController> logger)
        {
            _unitOfWork = unitOfWork;
			_logger = logger;

		}
    }
}
