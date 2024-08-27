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
            var AllAgentDetails = await _httpClient.GetFromJsonAsync<AgentStatus>("http://localhost:5258/agents/allDetails");
            
            return View(AllAgentDetails);
        }
    }
}

