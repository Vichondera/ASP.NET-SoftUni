namespace All4Auto.DataProcessor.Configurations
{
    using All4Auto.DataProcessor.Models.Vehicles;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MakeConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(CreateMake());
        }

        private List<Make> CreateMake() 
        {
            var makes = new List<Make>();

            makes.Add(new Make { Id = 1, Name = "Audi",Models = new List<Model>() });
            makes.Add(new Make { Id = 2, Name = "AlfaRomeo", Models = new List<Model>() });
            makes.Add(new Make { Id = 3, Name = "Bmw", Models = new List<Model>() });
            makes.Add(new Make { Id = 4, Name = "Opel", Models = new List<Model>() });
            makes.Add(new Make { Id = 5, Name = "Honda", Models = new List<Model>() });
            makes.Add(new Make { Id = 6, Name = "Mitsubishi", Models = new List<Model>() });
            makes.Add(new Make { Id = 7, Name = "Toyota", Models = new List<Model>() });
            makes.Add(new Make { Id = 8, Name = "Subaru", Models = new List<Model>() });
            makes.Add(new Make { Id = 9, Name = "VW", Models = new List<Model>() });

            return makes;
        }
    }
}
