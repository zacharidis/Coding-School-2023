using Microsoft.AspNetCore.Mvc;

namespace GZFuel.Blazor.Server.Controllers
{
	public class TransactionLineController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
