namespace All4Auto.DataProcessor.Models.Vehicles
{
    using All4Auto.DataProcessor.Models.CarGarage;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CarModel
    {
        public CarModel()
        {
            OwnedModels  = new List<OwnedModel>();
        }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public CarBrand Brand { get; set; } = null!;

        [ForeignKey(nameof(Brand))]
        public int BrandId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string TypeCar { get; set; } = null!;

        [Required]
        public string BodyType { get; set; } = null!;

        [Required]
        [StringLength(6, MinimumLength = 6)]
        public string InitialYear { get; set; } = null!;

        [StringLength(6, MinimumLength = 6)]
        public string FinalYear { get; set; } = null!;

        public string KV { get; set; } = null!;
        public string PM { get; set; } = null!;
        public string CC { get; set; } = null!;

        public string? TTC_TYP_ID { get; set; }
        public string? TTC_MOD_ID { get; set; }
        public string? TTC_MFA_ID { get; set; }
        public string? ENGINES { get; set; }

        public ICollection<OwnedModel> OwnedModels { get; set; }
    }
}
