using Microsoft.AspNetCore.Mvc;

namespace AgentManagementWiew.Controllers
{
    public class ManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
