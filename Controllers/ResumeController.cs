using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeMvc.Data;

namespace ResumeMvc.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ResumeController(ApplicationDbContext db) => _db = db;

        public async Task<IActionResult> Index()
        {
            var resume = await _db.Resumes
                .Include(r => r.Ilike)
                .Include(r => r.Educations)
                .Include(r => r.My_Skills)
                .FirstOrDefaultAsync();

            if (resume == null) return View("Empty");

            return View(resume);
        }
    }
}
