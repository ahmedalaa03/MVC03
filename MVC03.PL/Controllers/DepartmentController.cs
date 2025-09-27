using Microsoft.AspNetCore.Mvc;
using MVC03.BLL.Repositories;


namespace MVC03.PL.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            DepartmentRepository departmentRepository = new DepartmentRepository();
            var departments = departmentRepository.GetAll();

            return View(departments);
        }
    }
}
