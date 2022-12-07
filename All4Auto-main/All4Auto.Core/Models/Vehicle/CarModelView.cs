namespace All4Auto.Core.Models.Vehicle
{
    using All4Auto.DataProcessor.Models.CarGarage;

    public class CarModelView
    {
        public int BrandId { get; set; }

        public string Name { get; set; } = null!;

        public string TypeCar { get; set; } = null!;

        public string BodyType { get; set; } = null!;

        public string InitialYear { get; set; } = null!;

        public string FinalYear { get; set; } = null!;
        public string KV { get; set; } = null!;
        public string PM { get; set; } = null!;
        public string CC { get; set; } = null!;

        public string? TTC_TYP_ID { get; set; }
        public string? TTC_MOD_ID { get; set; }
        public string? TTC_MFA_ID { get; set; }
        public string? ENGINES { get; set; }

        public IEnumerable<OwnedModel>? OwnedModels { get; set; }
    }
}
