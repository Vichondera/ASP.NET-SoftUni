namespace All4Auto.DataProcessor.Models.Vehicles
{
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.ComponentModel.DataAnnotations;

    public class MainParts
    {
        [Key]
        public string SKU { get; set; } = null!;

        [Required]
        public string Manufacturer { get; set; } = null!;

        [Required]
        public string Model { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public int Status { get; set; }
        public string MetaKeyWord { get; set; } = null!;
        public string ProductTags { get; set; } = null!;
        public string DataAvailable { get; set; } = null!;
    }
}
//table data spare parts [MainParts]
