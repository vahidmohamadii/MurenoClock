using BusinessLayer.Dtos.Common;
using BusinessLayer.Repository;
using DataLayer.Entities.common;
using Microsoft.AspNetCore.Mvc;

namespace MurenoClock.Controllers.CrudControllerr;

public class CrudController<TDto,TSelectDto,TEntity,Tkey> : Controller
    where TDto : BaseDto<TDto,TEntity,Tkey>
    where TSelectDto: BaseDto<TSelectDto, TEntity, Tkey>
    where TEntity : BaseEntity<Tkey> ,new()
{
    public readonly IGenericRepository<TEntity> _repository;

    public CrudController(IGenericRepository<TEntity> repository)
    {
            _repository=repository;
    }
    // GET: CrudController
    public async Task<ActionResult<TSelectDto>> GetAll()
    {
        var res = await _repository.GetAllAsync();
        return View(res);
    }

    // GET: CrudController/Create
    public async Task<ActionResult<TSelectDto>> Create()
    {
        return View();
    }

    // POST: CrudController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult<TSelectDto>> Create(TDto model,CancellationToken cancellationToken)
    {
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

        return RedirectToAction(nameof(Index));
  
    }
}
