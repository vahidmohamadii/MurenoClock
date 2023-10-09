
using BusinessLayer.Dtos.About;
using BusinessLayer.Repository;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using MurenoClock.Controllers.CrudController;

namespace MurenoClock.Controllers;

public class AboutController : Controller/*: CrudController<AboutDto, SelectAboutDto, About, int>*/
{

    public IActionResult Create()
    {
        return View();
    }

    //public AboutController(IGenericRepository<About> repository) : base(repository)
    //{
    //}
}
