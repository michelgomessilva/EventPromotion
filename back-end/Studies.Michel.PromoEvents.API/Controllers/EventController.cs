using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studies.Michel.PromoEvents.API.Models;

namespace Studies.Michel.PromoEvents.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        public EventController()
        {            
        }

        [HttpGet]
        public IEnumerable<EventModel> Get()
        {
            return new EventModel[]
            {
                new EventModel()
                {
                    EventId = 1,
                    Theme = "Angular 11 e .Net Core 8",
                    Location = "Porto",
                    Batch = "1º Lote",
                    PeopleCount = 250,
                    EventDate = DateTime.Now.AddDays(2).ToString(),
                    ImageURL = "foto.jpg"
                }
            };
        }
    }
}
