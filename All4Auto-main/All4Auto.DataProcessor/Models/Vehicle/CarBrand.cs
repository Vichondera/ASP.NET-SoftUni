namespace All4Auto.DataProcessor.Models.Vehicle
{
    using System.ComponentModel.DataAnnotations;

    public class CarBrand
    {
        public CarBrand()
        {
            Models = new List<CarModel>();
        }
     
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public ICollection<CarModel> Models { get; set; }
    }
}
