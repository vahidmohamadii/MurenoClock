using BusinessLayer.Dtos.About;
using BusinessLayer.Dtos.Language;
using BusinessLayer.Repository.IEntityRepository;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace MurenoClock.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILanguageRepository _languageRepository;


        public HomeController(ILogger<HomeController> logger, ILanguageRepository languageRepository)
        {
            _logger = logger;
            _languageRepository = languageRepository;

        }

        public async Task<ActionResult<SelectLanguageDto>> Index()
        {
            ViewBag.languages = await _languageRepository.GetAllAsync();
            return View();
        }
        public async Task<ActionResult<SelectLanguageDto>> languages()
        {
            var res =await _languageRepository.GetAllAsync();
            SelectLanguageDto selectLanguageDto = new SelectLanguageDto();
            return PartialView(res);
        }


        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName
                , CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTime.UtcNow.AddYears(1) });
            return Redirect(Request.Headers["Referer"].ToString());
        }


    }
}