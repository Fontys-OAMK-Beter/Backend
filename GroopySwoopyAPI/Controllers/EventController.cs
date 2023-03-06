using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroopySwoopyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public IEnumerable<Event> Get(int id)
        {

            List<Event> events = new List<Event>();
            events.Add(new Event());
            events.LastOrDefault().Id = id;
            events.LastOrDefault().Description = "Lekker evenementje joah";
            events.LastOrDefault().Title = "Wouter's verjaardag";
            events.LastOrDefault().PictureURL = "https://www.speeleiland.nl";
            events.LastOrDefault().StartTime = DateTime.Now;

            return events.ToArray();
        }

        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
