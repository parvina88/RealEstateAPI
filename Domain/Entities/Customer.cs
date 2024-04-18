namespace Domain.Entities;

public class Customer : Person
{
    public ICollection<Deal> Deals { get; set; }

}