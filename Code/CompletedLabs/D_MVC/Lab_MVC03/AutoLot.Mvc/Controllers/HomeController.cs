// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Mvc - HomeController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/10
// ==================================

namespace AutoLot.Mvc.Controllers;

[Route("[controller]/[action]")]
//[Route("Home/[action]")]
public class HomeController(IAppLogging<HomeController> logger) : Controller
{
    //[Route("/MyHomePage")] 
    [Route("/")]
    [Route("/[controller]")]
    [Route("/[controller]/[action]")]
    [HttpGet]
    public IActionResult Index([FromServices]IOptionsMonitor<DealerInfo> dealerOptionsMonitor)
    {
        //logger.LogAppError("Test error");
        return View(dealerOptionsMonitor.CurrentValue);
    }

    [HttpGet]
    public IActionResult GetServiceOne(
        [FromKeyedServices(nameof(SimpleServiceOne))] ISimpleService service)
    {
        return View("SimpleService",service.SayHello());
    }

    [HttpGet]
    public IActionResult GetServiceTwo(
        [FromKeyedServices(nameof(SimpleServiceTwo))] ISimpleService service)
    {
        return View("SimpleService",service.SayHello());
    }

    [HttpGet]
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
