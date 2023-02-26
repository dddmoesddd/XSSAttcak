using Microsoft.AspNetCore.Mvc;

namespace XSSAttcak.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(StudentViewModel model)
        {

            return View("Result",model);
        }
    }
}
