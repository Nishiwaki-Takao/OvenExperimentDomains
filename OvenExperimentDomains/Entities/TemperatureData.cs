namespace OvenExperimentDomains.Entities
{
    public class TemperatureData
    {
        public int TemperatureDataId { get; set; }
        public DateTime Timestamp { get; set; }
        public double TemperatureCelsius { get; set; }

        // 外部キー
        public int DataPointId { get; set; }

        // ナビゲーション
        public DataPoint DataPoint { get; set; }
    }
}
