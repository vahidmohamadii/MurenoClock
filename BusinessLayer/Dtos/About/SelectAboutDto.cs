
using AutoMapper;
using BusinessLayer.Dtos.Common;
using DataLayer.Entities;

namespace BusinessLayer.Dtos.About;

public class SelectAboutDto:BaseDto<SelectAboutDto,DataLayer.Entities.About,int>
{

    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageFileName { get; set; }
}
