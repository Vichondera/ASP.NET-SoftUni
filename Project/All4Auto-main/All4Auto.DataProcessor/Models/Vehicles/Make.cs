namespace All4Auto.DataProcessor.Models.Vehicles
{
    using System.ComponentModel.DataAnnotations;

    public class Make
    {
        public Make()
        {
            Models = new List<Model>();
        }
     
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public ICollection<Model> Models { get; set; }
    }
}
