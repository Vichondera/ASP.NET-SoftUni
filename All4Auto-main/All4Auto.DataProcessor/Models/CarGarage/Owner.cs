namespace All4Auto.DataProcessor.Models.CarGarage
{
    using All4Auto.DataProcessor.Models.Account;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Owner 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Nickname { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; } = null!;
    }
}
