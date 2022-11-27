using All4Auto.DataProcessor.Models.Vehicles;

namespace All4Auto.Core.Models.Vehicles
{
    public class MakeQueryModel
    {
        public int TotalMakesCount { get; set; }
        public ICollection<Make> Makes { get; set; }
            = new List<Make>();
    }
}
