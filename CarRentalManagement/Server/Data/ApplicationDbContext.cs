using CarRentalManagement.Server.Configurations.Entities;
using CarRentalManagement.Server.Models;
using CarRentalManagement.Shared.Domain;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace CarRentalManagement.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public virtual Make? Make { get; set; }
        public virtual Model? Model { get; set; }

        public virtual Colour? Colours { get; set; }

        public virtual DbSet<Customer>? Customers { get; set; }
        public virtual DbSet<Booking>? Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ColourSeedConfiguration());
            builder.ApplyConfiguration(new ModelSeedConfiguration());
            builder.ApplyConfiguration(new MakeSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());

        }

        public DbSet<CarRentalManagement.Shared.Domain.Make> Make_1 { get; set; } = default!;

        public DbSet<CarRentalManagement.Shared.Domain.Colour> Colour { get; set; } = default!;

        public DbSet<CarRentalManagement.Shared.Domain.Model> Model_1 { get; set; } = default!;
    }
}