namespace All4Auto.Core.Models.Vehicle
{
    using All4Auto.DataProcessor.Models.Vehicles;

    public class CarBrandView
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public IEnumerable<CarModel>? Models { get; set; }
    }
}
