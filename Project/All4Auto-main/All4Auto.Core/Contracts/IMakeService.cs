namespace All4Auto.Core.Models.Catalog
{
    using All4Auto.DataProcessor.Models.Vehicles;
    
    public class MakeViewModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = null!;

        public IEnumerable<Model> Models { get; set; } = null!;
    }
}
