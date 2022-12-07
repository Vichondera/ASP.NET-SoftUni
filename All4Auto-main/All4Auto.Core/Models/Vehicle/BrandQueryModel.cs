namespace All4Auto.Core.Models.Vehicles
{
    using All4Auto.DataProcessor.Models.Vehicles;
    
    public class BrandQueryModel
    {
        public int TotalMakesCount { get; set; }
        
        public ICollection<Make> Makes { get; set; }
            = new List<Make>();
    }
}
