// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Web - Delete.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/10
// ==================================

namespace AutoLot.Web.Pages.Cars;

public class DeleteModel(
    IAppLogging<DeleteModel> appLogging,
    ICarDataService dataService)
    : BasePageModel<Car, DeleteModel>(appLogging, dataService, "Delete")
{
    public async Task OnGetAsync(int? id)
    {
        if (!id.HasValue)
        {
            Error = "Invalid request";
            Entity = null;
            return;
        }
        await GetOneAsync(id);
    }
    public async Task<IActionResult> OnPostAsync(int id) => await DeleteOneAsync(id);
}