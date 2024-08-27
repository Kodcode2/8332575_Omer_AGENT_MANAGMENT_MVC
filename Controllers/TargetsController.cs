using AgentManagementWiew.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AgentManagementWiew.Controllers
{
    public class TargetsController : Controller
    {
        private readonly HttpClient _httpClient;

        public TargetsController(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }
        public async Task<IActionResult> AgentStatus()
        {
            AgentStatus agentStatus = new AgentStatus();

            // קבלת פרטי כל המטרות
            var AllTargetDetails = await _httpClient.GetFromJsonAsync<TargetsStatus>("http://localhost:5258/targets/allDetails");
           
            return View(AllTargetDetails);
        }
    }
}
