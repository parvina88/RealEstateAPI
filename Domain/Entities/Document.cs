using Domain.Enum;

namespace Domain.Entities
{
    public class Document
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public DocumentType Type { get; set; }
        public DateTime Date { get; set; }
    }
}
