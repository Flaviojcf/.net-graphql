using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace TransferPay.Data.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<PropertyModel> PropertyModel { get; set; }
        public DbSet<PaymentModel> PaymentModel { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var properties = modelBuilder.Model
                .GetEntityTypes()
                .SelectMany(p => p.GetProperties())
                .Where(p => p.ClrType == typeof(string)
                    && p.GetColumnType() is null);

            foreach (var property in properties)
                property.SetIsUnicode(false);

            modelBuilder.ApplyConfigurationsFromAssembly(assembly: GetType().Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
