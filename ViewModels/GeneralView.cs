using AgentManagementWiew.Models;

namespace AgentManagementWiew.ViewModels
{
    public class GeneralView
    {
        public int? AllAgants { get; set; }
        public int? ActiveAgants { get; set; }

        public int? AllTargets { get; set; }
        public int? KilledTargets { get; set; }


        public int? AllMissions { get; set; }
        public int? ActiveMissions { get; set; }

        public string AgantTargets { get; set; } = "";

        public string AgantMissions { get; set; } = "";
    }
}
