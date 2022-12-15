namespace All4Auto.DataProcessor
{
    using All4Auto.DataProcessor.Configurations;
    using All4Auto.DataProcessor.Models.Account;
    using All4Auto.DataProcessor.Models.CarGarage;
    using All4Auto.DataProcessor.Models.Vehicles;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class All4AutoDbContext : IdentityDbContext<UserProfile>
    {
        public All4AutoDbContext(DbContextOptions<All4AutoDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CarBrandConfiguration());
            builder.ApplyConfiguration(new CarModelConfiguration());
            builder.ApplyConfiguration(new PartBrandConfiguration());
            builder.ApplyConfiguration(new MainPartsConfiguration());

            builder.Entity<UserCar>(entity =>
            {
                entity.HasKey(ct => new { ct.OwnerId, ct.CarId });
            });

            base.OnModelCreating(builder);
        }

        public DbSet<CarBrand> CarBrands { get; set; } = null!;
        public DbSet<CarModel> CarModels { get; set; } = null!;

        public DbSet<Garage> Garages { get; set; } = null!;

        public DbSet<Owner> Owners { get; set; } = null!;

        public DbSet<UserCar> UserCars { get; set; } = null!;

        public DbSet<PartBrand> PartBrands { get; set; } = null!;
    }
}
