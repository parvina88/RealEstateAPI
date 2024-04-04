namespace Domain.Entities
{
    public class Entrance : BaseEntity
    {
        public required string Number { get; set; }
        public int NumberFloor { get; set; }
        public int NumberApartmentPerFloor { get; set; }
        public bool HasList { get; set; }

        public Building Building { get; set; }
        public Guid BuildingId { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
