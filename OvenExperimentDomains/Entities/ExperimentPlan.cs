﻿namespace OvenExperimentDomains.Entities
{
    public class ExperimentPlan
    {
        public int ExperimentPlanId { get; set; }
        public required string PlanName { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<Experiment>? Experiments { get; set; }
    }

}
