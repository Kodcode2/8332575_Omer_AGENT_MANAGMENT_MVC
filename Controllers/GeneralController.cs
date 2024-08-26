using AgentManagementWiew.Models;
using AgentManagementWiew.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

public class AagentController : Controller
{


    private readonly HttpClient _httpClient;

    public AagentController(HttpClient httpClient)
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
        var ActiveAgents = await _httpClient.GetStringAsync("http://localhost:5258/agents/Active");

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
        var CountMissions = await _httpClient.GetStringAsync("http://localhost:5258/Agents/count");
        // המרה למודל התצוגה
        generalView.AllMissions = JsonConvert.DeserializeObject<int>(CountMissions);

        // קבלת מספר משימות פעילות
        var CountActiveMissions = await _httpClient.GetStringAsync("http://localhost:5258/Agents/Active");
        // המרה למודל התצוגה
        generalView.ActiveMissions = JsonConvert.DeserializeObject<int>(CountActiveMissions);

        // קבלת מספר יחסי של סוכנים למטרות
        var resultRelativeAgentTargets = await _httpClient.GetStringAsync("http://localhost:5258/Agents/relative");
        // המרה למודל התצוגה
        generalView.AgantTargets = resultRelativeAgentTargets;

        // קבלת מספר יחסי של סוכנים למשימות
        var resultRelativeAgentMissions = await _httpClient.GetStringAsync("http://localhost:5258/Agents/relativeAgant");
        // המרה למודל התצוגה
        generalView.AgantMissions = resultRelativeAgentMissions;

        return View(generalView);
    }

   

    public async Task<IActionResult> דף3()
    {
        ConnectPage3 page3 = new ConnectPage3();

        // קבלת פרטי כל המטרות
        var resultAllTargetDetails = await _httpClient.GetStringAsync("http://localhost:5157/api/targets/allDetails");
        // המרה למודל התצוגה
        page3.targetMVCs = JsonConvert.DeserializeObject<List<string>>(resultAllTargetDetails);

        return View(page3);
    }


}


