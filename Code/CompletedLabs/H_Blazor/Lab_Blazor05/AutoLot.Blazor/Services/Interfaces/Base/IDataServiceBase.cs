// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Blazor - IDataServiceBase.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/10/02
// ==================================

namespace AutoLot.Blazor.Services.Interfaces.Base;

public interface IDataServiceBase<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> GetEntityAsync(int id);
    Task<TEntity> AddEntityAsync(TEntity entity);
    Task<TEntity> UpdateEntityAsync(int id, TEntity entity);
    Task DeleteEntityAsync(TEntity entity);
    Task<List<TEntity>> GetAllEntitiesAsync();
}