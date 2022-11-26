namespace All4Auto.DataProcessor.Models.Vehicles
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Vehicle
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public Model Model { get; set; } = null!;

        [ForeignKey(nameof(Model))]
        public int ModelId { get; set; }
    }
}
