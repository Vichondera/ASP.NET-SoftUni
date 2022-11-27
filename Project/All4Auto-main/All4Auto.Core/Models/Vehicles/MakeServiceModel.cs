namespace All4Auto.Core.Models.Vehicles
{
    using All4Auto.DataProcessor.Models.Vehicles;
    using System.ComponentModel.DataAnnotations;
    public class MakeServiceModel
    {
        public int Id { get; set; }

        [Display(Name= "Brand Name")]
        public string Name { get; set; } = null!;

        public ICollection<Model> Models { get; set; } = new List<Model>();
    }
}
