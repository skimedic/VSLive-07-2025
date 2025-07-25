// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Web - Index.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/10
// ==================================

namespace AutoLot.Web.Pages.Cars;

public class IndexModel(IAppLogging<IndexModel> appLogging, ICarRepo repo)
    : BasePageModel<Car, IndexModel>(appLogging, repo, "Inventory")
{
    private readonly IAppLogging<IndexModel> _appLogging = appLogging;
    public string MakeName { get; set; }
    public int? MakeId { get; set; }
    public IEnumerable<Car> CarRecords { get; set; }
    public void OnGet(int? makeId, string makeName)
    {
        if (!makeId.HasValue)
        {
            MakeName = "All Makes";
            CarRecords = repo.GetAllIgnoreQueryFilters();
            return;
        }
        MakeId = makeId;
        MakeName = makeName;
        CarRecords =  repo.GetAllBy(makeId.Value);
    }
}