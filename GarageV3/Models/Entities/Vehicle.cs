using GarageV3.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GarageV3.Models.Entities
{
    [Index(nameof(RegistrationNumber), IsUnique = true)]
    public class Vehicle
    {
        public int Id { get; set; }

        public required int VehicleTypeRefId { get; set; }
        public VehicleTypeEntity? VehicleTypeRef { get; set; }

        public required string OwnerId { get; set; }
        public ApplicationUser? Owner { get; set; }

        [MaxLength(20)]
        public required string RegistrationNumber { get; set; }

        [MaxLength(20)]
        public string Color { get; set; } = string.Empty;

        [MaxLength(30)]
        public string Brand { get; set; } = string.Empty;

        [MaxLength(40)]
        public string Model { get; set; } = string.Empty;

        public int NumberOfWheels { get; set; }

        //public DateTime ArrivalTime { get; set; }
    }
}