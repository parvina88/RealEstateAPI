using Domain.Enum;

namespace Domain.Entities
{
    public class Apartment : BaseEntity
    {
        public int Number { get; set; }
        public decimal PricePerSquare { get; set; }
        public double TotalArea { get; set; }
        public double LivingArea { get; set; }
        public int NumberRooms { get; set; }
        public bool HasBalcon { get; set; }
        public ApartmentStatus Status { get; set; }
        public ApartmentType Type { get; set; }
        public decimal Cost => PricePerSquare * Convert.ToDecimal(TotalArea);   //compute

        public Entrance Entrance { get; set; }
        public Guid EntranceId { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
