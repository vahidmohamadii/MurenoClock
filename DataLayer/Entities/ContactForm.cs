namespace DataLayer.Entities;

public class ContactForm: BaseEntity.BaseEntity
{
    public string Title { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
}
