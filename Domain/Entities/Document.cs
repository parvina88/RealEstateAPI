using Domain.Enum;

namespace Domain.Entities
{
    public class Document : BaseEntity
    {
        public string Number { get; set; }
        public string Description { get; set; }
        public DocumentType Type { get; set; }
        public DateTime Date { get; set; }
    }
}
