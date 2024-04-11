namespace Domain.Entities
{
    public class Deal : BaseEntity
    {
        public string Number { get; set; }
        public DateTime Date { get; set; }

        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }

        public Apartment Apartment { get; set; }
        public Guid ApartmentId { get; set; }

        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }

        public virtual ICollection<DealDocument> DealDocuments { get; set; }
    }
}
