﻿

using BusinessLayer.Dtos.OnlineSell;
using DataLayer.Entities;

namespace BusinessLayer.Repository.IEntityRepository;

public interface IOnlineSellRepository : IGenericRepository<OnlineSell,OnlineSellDto>
{
}
