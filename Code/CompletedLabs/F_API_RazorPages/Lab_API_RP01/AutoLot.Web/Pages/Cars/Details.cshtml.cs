// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Web - Details.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/29
// ==================================

namespace AutoLot.Web.Pages.Cars;

public class DetailsModel(
    IAppLogging<DetailsModel> appLogging,
    ICarDataService dataService)
    : BasePageModel<Car, DetailsModel>(appLogging, dataService, "Details")
{
    public async Task OnGetAsync(int? id) => await GetOneAsync(id);
}