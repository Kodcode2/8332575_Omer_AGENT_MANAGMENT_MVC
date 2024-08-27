using AgentManagementWiew.Models;

namespace AgentManagementWiew.ViewModels
{
    public class AgentStatus
    {
        public string AgantDetails { get; set; } = "";

        public List<Agent> AllAgantsDetails { get; set; } = new List<Agent>();

        public string? Location { get; set; }

        public string? Status { get; set; }

        public Mission Mission { get; set; }

        public double TimeLiquidation { get; set; }

        public int AmounEliminations { get; set; }

    }


}
