using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Suitshop.Utility;

namespace Suitshop.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = SD.Role_Admin)]
	public class DashboardController : Controller
	{
		[Route("dashboard")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
