﻿using AutoMapper;
using BusinessLayer.CustomMapping;
using DataLayer.Entities.common;


namespace BusinessLayer.Dtos.Common;

public abstract class BaseDto<TDto,TEntity,Tkey>:IhaveCustomMapping 
    where TEntity : BaseEntity<Tkey>, new()
    where TDto : class, new()
{
 

    public Tkey Id { get; set; }
    public int PageId { get; set; }

    public TEntity ToEntity()
    {
        var config = new MapperConfiguration(cf => cf.CreateMap<TDto, TEntity>());
        var mapper = new Mapper(config);
        return mapper.Map<TEntity>(CastToDrivedClass(this));
    }
    public TEntity ToEntity(TEntity entity)
    {
        var config = new MapperConfiguration(cf => cf.CreateMap<TDto, TEntity>());
        var mapper = new Mapper(config);
        return mapper.Map(CastToDrivedClass(this), entity);
    }
    protected TDto CastToDrivedClass(BaseDto<TDto, TEntity, Tkey> model)
    {
        var config = new MapperConfiguration(cf => cf.CreateMap<TDto,TEntity>());
        var mapper = new Mapper(config); 
        return mapper.Map<TDto>(model);
    }
    public TDto TODto(TEntity entity)
    {
        var config = new MapperConfiguration(cf => cf.CreateMap<TEntity, TDto>());
        var mapper = new Mapper(config);
        return mapper.Map<TDto>(entity);
    }

    public void Createmapping(AutoMapper.Profile profile)
    {
       var Mapping =  profile.CreateMap<TDto, TEntity>();

        var dtotype = typeof(TDto);
        var entitytype=typeof(TEntity);

        foreach (var item in entitytype.GetProperties())
        {
            if(dtotype.GetProperty(item.Name) == null)
            {
                Mapping.ForMember(item.Name, x => x.Ignore());
            }

        }
        Custommappings(Mapping.ReverseMap());
    }

    public virtual void Custommappings(IMappingExpression<TEntity,TDto> mapping)
    {

    }

}
