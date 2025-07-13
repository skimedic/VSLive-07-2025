// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Api - ValuesController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/13
// ==================================

namespace AutoLot.Api.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ValuesController(IAppLogging<ValuesController> logger) : ControllerBase
{
    [HttpGet("problem")]
    public IActionResult Problem() => NotFound();

    [HttpGet("logging")]
    public IActionResult TestLogging()
    {
        logger.LogAppError("Test error");
        return Ok();
    }

    [HttpGet("error")]
    public IActionResult TestExceptionHandling()
    {
        throw new Exception("Test Exception");
    }
}
