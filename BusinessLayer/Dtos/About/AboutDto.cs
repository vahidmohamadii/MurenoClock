using AutoMapper;
using BusinessLayer.Dtos.Common;
using Microsoft.AspNetCore.Http;

namespace BusinessLayer.Dtos.About;

public class AboutDto:BaseDto<AboutDto, DataLayer.Entities.About,int>
{
    public AboutDto(IMapper mapper) : base(mapper)
    {
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageFileName { get; set; }
    public IFormFile ImageFile { get; set; }



}
