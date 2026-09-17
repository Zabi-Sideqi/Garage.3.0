using System.ComponentModel.DataAnnotations.Schema;

namespace GarageV3.Models.Entities
{
    public class ParkingSession
    {
        public int Id { get; set; }

        public int? VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }

        public string OwnerIdAtCheckIn { get; set; } = string.Empty;
        public string OwnerEmailAtCheckIn { get; set; } = string.Empty;

        public string RegistrationNumberAtCheckIn { get; set; } = string.Empty;
        public string VehicleTypeNameAtCheckIn { get; set; } = string.Empty;
        public string VehicleTypeIconAtCheckIn { get; set; } = string.Empty;
        public int RequiredSpotsAtCheckIn { get; set; }

        public string BrandAtCheckIn { get; set; } = string.Empty;
        public string ModelAtCheckIn { get; set; } = string.Empty;
        public string ColorAtCheckIn { get; set; } = string.Empty;
        public int NumberOfWheelsAtCheckIn { get; set; }

        public required int ParkingSpotId { get; set; }
        public ParkingSpot? ParkingSpot { get; set; }



        /// <summary>
        /// The actual spot(s) allocated to this session. For a normal vehicle
        /// this has exactly one entry using the whole spot's capacity; for a
        /// shared spot (motorcycles) it may share a spot with other sessions;
        /// for a large vehicle it has multiple entries across contiguous spots.
        /// </summary>
        public ICollection<ParkingAllocation> Allocations { get; set; } = new List<ParkingAllocation>();

        public DateTime ArriveTime { get; set; }
        public DateTime? CheckOutTime { get; set; }

        public decimal HourlyRateAtCheckIn { get; set; }
        public decimal? TotalPrice { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal AppliedDiscountPercentage { get; set; } // T.ex. 0.20

        /// <summary>
        /// Active means not yet checked out. Per spec, occupancy is derived
        /// from CheckOutTime being null rather than stored as a separate status field.
        /// </summary>
        public bool IsActive => CheckOutTime == null;
    }
}