namespace Together.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api")]
public class EventController : ControllerBase
{
    [Route("add-event")]
    public IActionResult AddEvent()
    {
        return Ok();
    }
}