namespace Together.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Together.Contract.Controller;
[ApiController]
[Route("api")]
public class EventController : ControllerBase
{
    [HttpPost("add-event")]
    public IActionResult AddEvent(AddEventRequest request)
    {
        return Ok(request);
    }
    [HttpPost("query-event")]
    public IActionResult QueryEvent(QueryEventRequest request)
    {
        return Ok(request);
    }
}