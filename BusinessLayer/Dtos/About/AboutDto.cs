using Microsoft.AspNetCore.Http;

namespace BusinessLayer.Dtos.About;

public class AboutDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageFileName { get; set; }
    public IFormFile ImageFile { get; set; }

}
