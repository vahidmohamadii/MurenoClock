
using BusinessLayer.Dtos.About;
using BusinessLayer.Repository;
using DataLayer.Entities;
using MurenoClock.Controllers.CrudController;

namespace MurenoClock.Controllers;

public class AboutController : CrudController<AboutDto, SelectAboutDto, About, int>
{
    public AboutController(IGenericRepository<About> repository) : base(repository)
    {
    }
}
