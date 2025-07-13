// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Web - Details.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/10
// ==================================

namespace AutoLot.Web.Areas.Admin.Pages.Makes;
public class DetailsModel(IAppLogging<DetailsModel> appLogging, IMakeDataService dataService)
  : BasePageModel<Make, DetailsModel>(appLogging, dataService, "Details")
{
  public async Task OnGetAsync(int? id) => await GetOneAsync(id);
}
