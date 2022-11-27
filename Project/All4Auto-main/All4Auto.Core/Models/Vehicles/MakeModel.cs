namespace All4Auto.Core.Models.Vehicles
{
    using System.ComponentModel.DataAnnotations;

    public class MakeModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
