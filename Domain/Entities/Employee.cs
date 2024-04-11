namespace Domain.Entities
{
    public class Employee : Person
    {
        public ICollection<Deal> Deals { get; set; }

    }
}