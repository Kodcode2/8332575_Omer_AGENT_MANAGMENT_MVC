using AgentManagementWiew.Models;
using AgentManagementWiew.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

public class GeneralController : Controller
{


    private readonly HttpClient _httpClient;

    public GeneralController(HttpClient httpClient)
    {

    _httpClient = httpClient; 

    }
    
    public async Task<IActionResult> GeneralView()
    {
        GeneralView generalView = new GeneralView();

        // סה"כ סוכנים
        var AllAgents = await _httpClient.GetStringAsync("http://localhost:5258/agents");

        // המרה למודל התצוגה
        generalView.AllAgants = JsonConvert.DeserializeObject<int>(AllAgents);

        // סה"כ סוכנים פעילים
        var ActiveAgents = await _httpClient.GetStringAsync("http://localhost:5258/agents/active");

        // המרה למודל התצוגה
        generalView.ActiveAgants = JsonConvert.DeserializeObject<int>(ActiveAgents);

        // קבלת מספר כולל של מטרות
        var CountAllTargets = await _httpClient.GetStringAsync("http://localhost:5258/targets/count");
        // המרה למודל התצוגה
        generalView.AllTargets = JsonConvert.DeserializeObject<int>(CountAllTargets);

        // קבלת מספר כולל של מטרות שהושמדו
        var CountKilled = await _httpClient.GetStringAsync("http://localhost:5258/targets/KilledCount");
        // המרה למודל התצוגה
        generalView.KilledTargets = JsonConvert.DeserializeObject<int>(CountKilled);

        // קבלת מספר כולל של משימות
        var CountMissions = await _httpClient.GetStringAsync("http://localhost:5258/missions/count");
        // המרה למודל התצוגה
        generalView.AllMissions = JsonConvert.DeserializeObject<int>(CountMissions);

        // קבלת מספר משימות פעילות
        var CountActiveMissions = await _httpClient.GetStringAsync("http://localhost:5258/missions/Active");
        // המרה למודל התצוגה
        generalView.ActiveMissions = JsonConvert.DeserializeObject<int>(CountActiveMissions);

        // קבלת מספר יחסי של סוכנים למטרות
        var resultRelativeAgentTargets = await _httpClient.GetStringAsync("http://localhost:5258/agents/relative");
        // המרה למודל התצוגה
        generalView.AgantTargets = resultRelativeAgentTargets;

        // קבלת מספר יחסי של סוכנים למשימות
        var resultRelativeAgentMissions = await _httpClient.GetStringAsync("http://localhost:5258/agents/relativeAgant");
        // המרה למודל התצוגה
        

        return View();
    }






}




        
