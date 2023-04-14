using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SammourProfile.Data;
using SammourProfile.Models;

namespace SammourProfile.Controllers
{
	public class ContactMeController : Controller
	{
        private readonly ApplicationDbContext Context;

        public ContactMeController(ApplicationDbContext _Context)
        {
            Context = _Context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateContact(Contact obj)
		{
            
                Context.Contacts.Add(obj);
                Context.SaveChanges();
                return RedirectToAction("ThanksMassege");
            
        }

        public IActionResult ThanksMassege()
        {
            return View();
        }
	}
}

