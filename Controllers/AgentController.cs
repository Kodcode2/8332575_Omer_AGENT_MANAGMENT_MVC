using AgentManagementWiew.Models;
using AgentManagementWiew.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace AgentManagementWiew.Controllers
{
    public class AgentController : Controller
    {

        private readonly HttpClient _httpClient;

        public AgentController(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }
        public async Task<IActionResult> AgentStatus()
        {
            AgentStatus agentStatus = new AgentStatus();

            // קבלת פרטי כל הסוכנים
            var resultAllAgentDetails = await _httpClient.GetStringAsync("http://localhost:5157/api/agants/allDetails");
            // המרה למודל התצוגה
            agentStatus._allAgantsDetails = JsonConvert.DeserializeObject<List<Agent>>(resultAllAgentDetails);

            return View(agentStatus);
        }
    }
}
