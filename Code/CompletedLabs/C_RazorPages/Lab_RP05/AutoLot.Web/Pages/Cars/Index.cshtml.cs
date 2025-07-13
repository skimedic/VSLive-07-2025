// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Web - Index.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/10
// ==================================

namespace AutoLot.Web.Pages.Cars;

public class IndexModel : PageModel
{
    public string MakeName { get; set; }
    public int? MakeId { get; set; }
    public void OnGet(int? makeId, string makeName)
    {
        MakeId = makeId;
        MakeName = makeName;
    }
}
