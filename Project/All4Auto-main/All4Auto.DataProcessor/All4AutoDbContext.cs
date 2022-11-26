namespace All4Auto.DataProcessor
{
    using All4Auto.DataProcessor.Configurations;
    using All4Auto.DataProcessor.Models.Account;
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
            builder.ApplyConfiguration(new MakeConfiguration());
            builder.ApplyConfiguration(new ModelConfiguration());
            builder.ApplyConfiguration(new VehicleConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<UserProfile> UsersProfiles { get; set; } = null!;

        public DbSet<Make> Makes { get; set; } = null!;
        public DbSet<Model> Models { get; set; } = null!;
        public DbSet<Vehicle> Vehicles { get; set; } = null!;

    }
}