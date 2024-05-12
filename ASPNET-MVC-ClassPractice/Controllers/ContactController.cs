using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_ClassPractice.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
