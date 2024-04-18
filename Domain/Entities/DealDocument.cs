namespace Domain.Entities;

public class DealDocument : BaseEntity
{
    public Document Document { get; set; }
    public Guid DocumentId { get; set; }
    public Deal Deal { get; set; }
    public Guid DealId { get; set; }
}