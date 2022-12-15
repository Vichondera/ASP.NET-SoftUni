namespace All4Auto.DataProcessor.Models.Vehicles
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class PartBrand
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public Guid Id { get; set; }
        public string Brand { get; set; } = null!;
      
        public int SupId { get; set; }

        public int BrandId { get; set; }
    }
}
