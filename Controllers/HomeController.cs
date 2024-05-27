using Microsoft.AspNetCore.Mvc;

namespace pr37savichev.Controllers
{
	public class HomeController : Controller
	{
		public RedirectResult Index()
		{
			return Redirect("Items/List");
		}
	}
}
