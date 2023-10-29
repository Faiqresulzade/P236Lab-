using LabProject.Models;
using LabProject.Services.Abstract;
using LabProject.Services.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace LabProject.Controllers
{
    public class HomeController:Controller
    {
        private readonly IAppDataContext _dataContext;

        public HomeController(IAppDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            return View(_dataContext.Teachers);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return BadRequest();

            List<Student> students = _dataContext.Students.FindAll(s => s.TeacherID == id);

            if (students == null) return NotFound();

            return View(students);
        }

        public IActionResult StudentDetails(int? id)
        {
            if (id == null) return BadRequest();
            
            Student? student=_dataContext.Students.Find(s => s.Id == id);
            if (student == null) return NotFound();

            return View("StudentDetail", student);
        }

    }
}
