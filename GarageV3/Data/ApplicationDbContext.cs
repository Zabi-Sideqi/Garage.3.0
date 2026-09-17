using GarageV3.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GarageV3.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Vehicle> Vehicles { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Vehicle>()
            .ToTable("Vehicles");

        builder.Entity<Vehicle>()
            .HasOne(v => v.Owner)
            .WithMany()
            .HasForeignKey(v => v.OwnerId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Vehicle>()
            .HasOne(v => v.VehicleTypeRef)
            .WithMany()
            .HasForeignKey(v => v.VehicleTypeRefId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Entity<ParkingSession>()
            .HasOne(s => s.Vehicle)
            .WithMany()
            .HasForeignKey(s => s.VehicleId)
            .OnDelete(DeleteBehavior.SetNull);


        builder.Entity<ParkingSession>()
            .HasOne(s => s.ParkingSpot)
            .WithMany()
            .HasForeignKey(s => s.ParkingSpotId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<ApplicationUser>()
            .HasIndex(u => u.PersonalIdentityNumber)
            .IsUnique();

        builder.Entity<ParkingSession>()
            .Property(s => s.HourlyRateAtCheckIn)
            .HasColumnType("decimal(10,2)");

        builder.Entity<ParkingSession>()
            .Property(s => s.TotalPrice)
            .HasColumnType("decimal(10,2)");

        builder.Entity<ParkingAllocation>()
            .HasOne(a => a.ParkingSession)
            .WithMany(s => s.Allocations)
            .HasForeignKey(a => a.ParkingSessionId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<ParkingAllocation>()
            .HasOne(a => a.ParkingSpot)
            .WithMany()
            .HasForeignKey(a => a.ParkingSpotId)
            .OnDelete(DeleteBehavior.Restrict);

        // Automatically mark all DateTime properties read from DB as Utc
        var utcConverter = new ValueConverter<DateTime, DateTime>(
            v => v.Kind == DateTimeKind.Utc ? v : v.ToUniversalTime(),
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            foreach (var property in entityType.GetProperties())
            {
                if (property.ClrType == typeof(DateTime) ||
                    property.ClrType == typeof(DateTime?))
                {
                    property.SetValueConverter(utcConverter);
                }
            }
        }
    }

    public DbSet<ParkingSession> ParkingSessions { get; set; }

    public DbSet<VehicleTypeEntity> VehicleTypes { get; set; }

    public DbSet<ParkingSpot> ParkingSpots { get; set; }

    public DbSet<ParkingAllocation> ParkingAllocations { get; set; }
}