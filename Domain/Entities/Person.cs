namespace Domain.Entities;

public abstract class Person : BaseEntity
{
    public string FullName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public Guid DocumentId { get; set; }
    public string Email { get; set; }
}