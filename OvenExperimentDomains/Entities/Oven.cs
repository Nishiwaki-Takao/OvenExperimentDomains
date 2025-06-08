namespace OvenExperimentDomains.Entities
{
    public class Oven
    {
        public int OvenId { get; set; }
        public string SerialNumber { get; set; }

        // 外部キー
        public int OvenModelId { get; set; }

        // ナビゲーション
        public OvenModel OvenModel { get; set; }
        public ICollection<Experiment> Experiments { get; set; }
    }
}
