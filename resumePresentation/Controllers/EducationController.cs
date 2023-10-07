using Microsoft.AspNetCore.Mvc;
using resumePresentation.Models.Entites.Education;
using resumePresentation.Models.Entites.ResumeDbContext;

namespace resumePresentation.Controllers
{
    public class EducationController : Controller
    {

        private ResumeDbContext _context;

        public EducationController(ResumeDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ListOfEducations()
        {
            List<Educations> educations = _context.Educations.ToList();

            return View();
        }
    }
}
