﻿// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Mvc - MakesController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/10
// ==================================

namespace AutoLot.Mvc.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]/[action]")]
public class MakesController(IAppLogging<MakesController> appLogging, IMakeRepo baseRepo)
    : BaseCrudController<Make, MakesController>(appLogging, baseRepo)
{
    protected override SelectList GetLookupValues() => null; 

    // GET: Admin/Makes
    [Route("/Admin")]
    [Route("/Admin/[controller]")]
    [Route("/Admin/[controller]/[action]")]
    public override IActionResult Index() => base.Index();
}
