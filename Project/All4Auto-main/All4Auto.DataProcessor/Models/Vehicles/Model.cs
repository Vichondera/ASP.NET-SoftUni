namespace All4Auto.DataProcessor.Models.Vehicles
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Model
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public Make Make { get; set; } = null!;

        [ForeignKey(nameof(Make))]
        public int MakeId { get; set; }

        //[Required]
        //[StringLength(7, MinimumLength = 7)]
        //public string InitialYear { get; set; } = null!;

        //[StringLength(7, MinimumLength = 7)]
        //public string FinalYear { get; set; } = null!;

        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();


    }
}
