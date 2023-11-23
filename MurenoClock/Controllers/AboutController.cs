
using BusinessLayer.Dtos.About;
using BusinessLayer.Repository;
using DataLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MurenoClock.Controllers.CrudController;

namespace MurenoClock.Controllers;

public class AboutController : Controller/*: CrudController<AboutDto, SelectAboutDto, About, int>*/
{
    private readonly UserManager<IdentityUser> _user;
    public AboutController(UserManager<IdentityUser> user)
    {
        _user=user;
    }
  
    public IActionResult Create()
    {
        _user.GeneratePasswordResetTokenAsync();
        _user.pho
        return View();
    }

    //public AboutController(IGenericRepository<About> repository) : base(repository)
    //{
    //}
}
