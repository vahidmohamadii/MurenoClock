using BusinessLayer.Dtos.Common;
using BusinessLayer.Repository;
using BusinessLayer.Utility;
using DataLayer.Entities.common;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Reflection;

namespace MurenoClock.Controllers.CrudController;

public class CrudController<TDto,TSelectDto,TEntity,Tkey> : Controller
    where TDto : BaseDto<TDto,TEntity,Tkey>,new()
    where TSelectDto: BaseDto<TSelectDto, TEntity, Tkey>,new()
    where TEntity : BaseEntity<Tkey> ,new()
{
    public readonly IGenericRepository<TEntity> _repository;

    public CrudController(IGenericRepository<TEntity> repository)
    {
            _repository=repository;
    }
 
    // GET: CrudController
    public async Task<ActionResult<TSelectDto>> Index()
    {
        var res = await _repository.GetAllAsync();
       List<TSelectDto> result=new List<TSelectDto>();
        TSelectDto selectdto = new TSelectDto();
        foreach (var item in res)
        {
           result.Add(selectdto.TODto(item));
        }
   
        return View(result);
    }

    // GET: CrudController/Create
    public async Task<ActionResult<TSelectDto>> Create()
    {
        return  View();
    }

    // POST: CrudController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult<TSelectDto>> Create(TDto model,CancellationToken cancellationToken)
    {

        ///insert Image 
        var ImageName = "";
        var dtoType=typeof(TDto);
        foreach (var item in dtoType.GetProperties().ToList())
        {
      
            if (item.PropertyType == typeof(IFormFile))
            {
              var imageFilemodel = item.GetValue(model);
              ImageName = InsertPhoto.Insert((IFormFile)imageFilemodel, "wwwroot/Images/About");
            }
        }
        foreach (var item in dtoType.GetProperties().ToList())
        {
            if (item.Name == "ImageFileName")
            {
          
                 item.SetValue(model, ImageName);
            }
        }
        var entity = model.ToEntity();
        await _repository.InsertAsync(entity, cancellationToken);

        return View();
    }

    // GET: CrudController/Edit/5
    public async Task<ActionResult<TSelectDto>> Edit(int id,CancellationToken cancellationToken)
    {
        var entity =await _repository.GetByIdAsync(id,cancellationToken);
        
        return View(entity);
    }

    // POST: CrudController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult<TSelectDto>> Edit(int id, TDto model,CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(id, cancellationToken);

        entity = model.ToEntity(entity);
        await _repository.UpdateAsync(entity, cancellationToken);

        return RedirectToAction(nameof(Index));
    }
  
 

    // GET: CrudController/Delete/5
    public async Task<ActionResult<TSelectDto>> Delete(int id, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(id, cancellationToken);
  
        return View(entity);
    }

    // POST: CrudController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult<TSelectDto>> DeleteById(int id, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(id, cancellationToken);
         await _repository.DeleteByEntityAsync(entity,cancellationToken);

        return RedirectToAction(nameof(Index));
  
    }
}
