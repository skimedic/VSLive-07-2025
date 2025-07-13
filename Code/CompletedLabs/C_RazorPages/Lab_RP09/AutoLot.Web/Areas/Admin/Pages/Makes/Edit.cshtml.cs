// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Web - Edit.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/10
// ==================================

namespace AutoLot.Web.Areas.Admin.Pages.Makes;
public class EditModel(IAppLogging<EditModel> appLogging, IMakeDataService dataService)
  : BasePageModel<Make, EditModel>(appLogging, dataService, "Edit")
{
  public async Task OnGetAsync(int? id) => await GetOneAsync(id);
  public async Task<IActionResult> OnPostAsync() => await SaveOneAsync(MainDataService.UpdateAsync);
}
