using Microsoft.AspNetCore.Mvc;
using SammourProfile.Data;
using SammourProfile.Models;

namespace SammourProfile.Controllers
{
    public class SkillController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SkillController(ApplicationDbContext db) 
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Skill> MySkills = _db.Skills.ToList();
            return View(MySkills);
        }
    }
}
