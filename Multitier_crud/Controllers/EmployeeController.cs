using BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;

namespace Multitier_crud.Controllers
{
    public class EmployeeController : Controller
    {
        public BLEmployeeBussiness bussiness=new BLEmployeeBussiness();
        public IActionResult Index()
        {
            var emp=bussiness.GetEmployees();
            return View(emp);
        }
    }
}
