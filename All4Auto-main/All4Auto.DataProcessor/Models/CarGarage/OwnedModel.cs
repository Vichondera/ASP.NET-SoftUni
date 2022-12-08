namespace All4Auto.DataProcessor.Models.CarGarage
{
    using All4Auto.DataProcessor.Models.Vehicles;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class OwnedModel
    {
        [Required]
        [ForeignKey(nameof(Owner))]
        public int OwnerId { get; set; }
        public Owner? Owner { get; set; }

        [Required]
        [ForeignKey(nameof(Model))]
        public Guid ModelId { get; set; }
        public CarModel? Model { get; set; }
    }
}
