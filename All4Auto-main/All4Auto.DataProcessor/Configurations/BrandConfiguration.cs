namespace All4Auto.DataProcessor.Configurations
{
    using All4Auto.DataProcessor.Models.Vehicles;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BrandConfiguration : IEntityTypeConfiguration<CarBrand>
    {
        public void Configure(EntityTypeBuilder<CarBrand> builder)
        {
            builder.HasData(InsertBrands());
        }

        private List<CarBrand> InsertBrands() 
        {
            var makes = new List<CarBrand>();

            makes.Add(new CarBrand { Id = 1, Name = "Audi",Models = new List<CarModel>() });
            makes.Add(new CarBrand { Id = 2, Name = "Acura", Models = new List<CarModel>() });
            makes.Add(new CarBrand { Id = 3, Name = "Bmw", Models = new List<CarModel>() });
            makes.Add(new CarBrand { Id = 4, Name = "Opel", Models = new List<CarModel>() });
            makes.Add(new CarBrand { Id = 5, Name = "Honda", Models = new List<CarModel>() });
            makes.Add(new CarBrand { Id = 6, Name = "Mitsubishi", Models = new List<CarModel>() });
            makes.Add(new CarBrand { Id = 7, Name = "Toyota", Models = new List<CarModel>() });
            makes.Add(new CarBrand { Id = 8, Name = "Subaru", Models = new List<CarModel>() });
            makes.Add(new CarBrand { Id = 9, Name = "VW", Models = new List<CarModel>() });

            return makes;
        }
    }
}
