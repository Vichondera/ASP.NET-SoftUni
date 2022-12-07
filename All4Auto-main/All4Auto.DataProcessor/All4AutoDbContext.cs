namespace All4Auto.DataProcessor
{
    using All4Auto.DataProcessor.Configurations;
    using All4Auto.DataProcessor.Models.Account;
    using All4Auto.DataProcessor.Models.CarGarage;
    using All4Auto.DataProcessor.Models.Garage;
    using All4Auto.DataProcessor.Models.Vehicles;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    public class All4AutoDbContext : IdentityDbContext<UserProfile>
    {
        public All4AutoDbContext(DbContextOptions<All4AutoDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MakeConfiguration());
            builder.ApplyConfiguration(new ModelConfiguration());
            

            builder.Entity<OwnedModel>(entity =>
            {
                entity.HasKey(ct => new { ct.OwnerId, ct.ModelId });
            });

            base.OnModelCreating(builder);
        }

        public DbSet<UserProfile> UsersProfiles { get; set; } = null!;

        public DbSet<CarBrand> Makes { get; set; } = null!;
        public DbSet<CarModel> Models { get; set; } = null!;
      //  public DbSet<Vehicle> Vehicles { get; set; } = null!;

        public DbSet<Garage> Garages { get; set; } = null!;

        public DbSet<Owner> Owners { get; set; } = null!;

        public DbSet<OwnedModel> OwnedModels { get; set; } = null!;

    }
}
