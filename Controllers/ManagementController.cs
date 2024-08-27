using Microsoft.AspNetCore.Mvc;

namespace AgentManagementWiew.Controllers
{
    public class ManagementController : Controller
    {
        private readonly HttpClient _httpClient;

        public ManagementController(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }
    }
}
