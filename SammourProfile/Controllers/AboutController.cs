using Microsoft.AspNetCore.Mvc;
using SammourProfile.Data;
using SammourProfile.Models;

namespace SammourProfile.Controllers
{
    public class AboutController : Controller
    {
		private readonly ApplicationDbContext Context;

		public AboutController(ApplicationDbContext _Context)
		{
			Context = _Context;
		}
		public IActionResult Index()
		{
			List<Expertise> MyExpertises = Context.Expertises.ToList();
			return View(MyExpertises);
		}
	}
}
