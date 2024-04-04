using Domain.Enum;

namespace Domain.Entities
{
    public class Apartment
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public decimal PricePerSquare { get; set; }
        public double TotalArea { get; set; }
        public double LivingArea { get; set; }
        public int NumberRooms { get; set; }
        public bool HasBalcon { get; set; }
        public ApartmentStatus Status { get; set; }
        public ApartmentType Type { get; set; }

        public Entrance Entrance { get; set; }
        public Guid EntranceId { get; set; }
    }
}
