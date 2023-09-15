

using BusinessLayer.Dtos.Common;

namespace BusinessLayer.Dtos.ContactForm;

public class UpdateContactFormDto:BaseDto
{
    public string Title { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
}
