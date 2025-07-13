// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Blazor - ICarDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/10/02
// ==================================

namespace AutoLot.Blazor.Services.Interfaces;

public interface ICarDataService : IDataServiceBase<Car>
{
    Task<List<Car>> GetByMakeAsync(int makeId);
}