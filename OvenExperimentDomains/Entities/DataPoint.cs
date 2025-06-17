namespace OvenExperimentDomains.Entities
{
    public class DataPoint
    {
        public int DataPointId { get; set; }
        public int Level { get; set; }     // 段
        public int Hole { get; set; }      // 穴番号

        // 外部キー
        public int ExperimentId { get; set; }

        // ナビゲーション
        public Experiment Experiment { get; set; }

        public ICollection<TemperatureData>? TemperatureDataRecords { get; set; }
    }

}
