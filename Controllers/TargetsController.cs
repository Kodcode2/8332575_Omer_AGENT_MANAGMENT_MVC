using Microsoft.AspNetCore.Mvc;

namespace AgentManagementWiew.Controllers
{
    public class TargetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
