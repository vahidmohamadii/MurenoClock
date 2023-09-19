using AutoMapper;
using BusinessLayer.Dtos.About;
using BusinessLayer.UnitOfWork;
using BusinessLayer.Utility;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MurenoClock.Controllers
{
    public class AboutController : Controller
    {
        private IUnitOfWork _unitOfWork { get; set; }
        private readonly IMapper _mapper;


        public AboutController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        // GET: AboutController
        public async Task<ActionResult> Index()
        {
            var entities =await _unitOfWork.About.GetAllAsync();

            return View(entities);
        }
        
        // GET: AboutController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AboutController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: AboutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AboutDto aboutdto)
        {
           
            if(aboutdto.ImageFile != null)
            {
                aboutdto.ImageFileName=  InsertPhoto.Insert(aboutdto.ImageFile, "wwwroot/Images/About");
            }
 
            var about = _mapper.Map<About>(aboutdto);
            _unitOfWork.About.InsertAsync(about, CancellationToken.None);

            return RedirectToAction(nameof(Index));

        }

        // GET: AboutController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
          
            var about =await _unitOfWork.About.GetByIdAsync(id, CancellationToken.None);
            var aboutdto = _mapper.Map<AboutDto>(about);
            return View(aboutdto);
        }

        // POST: AboutController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  ActionResult Edit(AboutDto aboutDto)
        {
            try
            {
                var about=_mapper.Map<About>(aboutDto);
                _unitOfWork.About.Update(about);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AboutController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var about =await _unitOfWork.About.GetByIdAsync(id,CancellationToken.None);
            var aboutdto = _mapper.Map<AboutDto>(about);
            return View(aboutdto);
        }

        // POST: AboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(AboutDto aboutdto)
        {
            try
            {
                var about =  _unitOfWork.About.DeleteById(aboutdto.Id);
                var res = _mapper.Map<AboutDto>(about);
                return View(res);
            }
            catch
            {
                return View();
            }
        }
    }
}
