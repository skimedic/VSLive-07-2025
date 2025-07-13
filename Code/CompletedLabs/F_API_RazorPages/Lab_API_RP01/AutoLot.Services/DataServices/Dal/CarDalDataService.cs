// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Services - CarDalDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/29
// ==================================

namespace AutoLot.Services.DataServices.Dal;

public class CarDalDataService(IAppLogging<CarDalDataService> appLogging, ICarRepo repo)
    : DalDataServiceBase<Car, CarDalDataService>(appLogging, repo), ICarDataService
{
    public Task<IEnumerable<Car>> GetAllByMakeIdAsync(int? makeId) 
        =>  Task.FromResult(makeId.HasValue 
            ? repo.GetAllBy(makeId.Value) 
            : MainRepo.GetAllIgnoreQueryFilters());
}