// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Web - RazorSyntax.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/10
// ==================================

namespace AutoLot.Web.Pages;

public class RazorSyntaxModel(ICarRepo repo, IMakeRepo makeRepo) : PageModel
{
    [ViewData]
    public SelectList LookupValues { get; set; } = 
        new(makeRepo.GetAll(), nameof(Make.Id), nameof(Make.Name));

    [ViewData]
    public string Title => "Razor Syntax";
    [BindProperty]
    public Car Entity { get; set; }

    public IActionResult OnGet()
    {
        Entity = repo.Find(6);
        return Page();
    }
}
