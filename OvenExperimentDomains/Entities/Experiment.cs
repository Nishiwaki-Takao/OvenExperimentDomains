namespace OvenExperimentDomains.Entities
{
    public class Experiment
    {
        public int ExperimentId { get; set; }
        public string ProductName { get; set; }
        public DateTime StartTime { get; set; }
        public int TotalLevelsUsed { get; set; }

        // 外部キー
        public int OvenId { get; set; }
        public int ExperimentPlanId { get; set; }

        // ナビゲーション
        public Oven Oven { get; set; }
        public ExperimentPlan ExperimentPlan { get; set; }

        public ICollection<DataPoint> DataPoints { get; set; }
    }


}
