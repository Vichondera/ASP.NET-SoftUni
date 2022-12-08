namespace All4Auto.DataProcessor.Models.CarGarage
{
    using All4Auto.DataProcessor.Models.Vehicles;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Garage
    {
        public Garage()
        {
            Models= new List<CarModel>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required] 
        public string GarageName { get; set; } = null!;

        [Required] 
        public string Description { get; set; } = null!;

        [Required]
        public int OwnerId { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public Owner Owner { get; set; } = null!;

        public List<CarModel> Models { get; set; }
    }
}
