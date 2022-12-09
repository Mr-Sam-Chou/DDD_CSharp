namespace Together.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Together.Application.Services;
using Together.Contract.Controller;
[ApiController]
[Route("api")]
public class EventController : ControllerBase
{
    private readonly IEventService eventService;
    public EventController(IEventService eventService)
    {
        this.eventService = eventService;
    }

    [HttpPost("add-event")]
    public IActionResult AddEvent(AddEventRequest request)
    {
        var result = eventService.add(request.name, request.coordinator, request.place, request.lat,
        request.lng, request.fee);
        AddEventResponse response = new AddEventResponse(
            result.Id, result.name, result.coordinator,
            result.place, result.lat, result.lng, result.fee
        );
        return Ok(response);
    }
    [HttpPost("query-event")]
    public IActionResult QueryEvent(QueryEventRequest request)
    {
        List<QueryEventResponse> events = new List<QueryEventResponse>();
        while (true)
        {
            if (events!.Count > 10)
            {
                break;
            }
            Random myObject = new Random();
            int ranNum = myObject.Next(100, 1000);
            events.Add(new QueryEventResponse("nane", "mark", "tpe", 20.4f, 121.3f, ranNum));
        }
        return Ok(events);
    }
}