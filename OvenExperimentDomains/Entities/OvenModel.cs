namespace OvenExperimentDomains.Entities
{
    public class OvenModel
    {
        public int OvenModelId { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        // ナビゲーションプロパティ
        public ICollection<Oven> Ovens { get; set; }
    }
}
