﻿using AgentManagementAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgentManagementWiew.Models
{
    public class Mission
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public Agent? Agent { get; set; }

        public int AgentID { get; set; }

        [NotMapped]
        public Target? Target { get; set; }

        public int TargetID { get; set; }

        public double? DurationTask { get; set; }

        public double? TimeLeft { get; set; }

        public StatusMission? StatusMission { get; set; }
    }
}
