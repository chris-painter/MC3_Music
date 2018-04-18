using System.Web.Mvc;

namespace MC3_Music.Controllers
{
	[Authorize]
	public class ServicesController : Controller
	{
		public ActionResult Index()
		{
			if (User.IsInRole("CanManageAlbums"))
				return View();
			else
				return RedirectToAction("Login", "Account");
		}
	}
}