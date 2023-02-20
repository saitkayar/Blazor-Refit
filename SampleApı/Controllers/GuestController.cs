using Microsoft.AspNetCore.Mvc;
using SampleApı.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private static List<GuestModel> guests = new List<GuestModel>()
        {
            new GuestModel{Id=1,FirstName="sait",LastName="kayar"},
            new GuestModel{Id=2,FirstName="saitt",LastName="kayarr"},
            new GuestModel{Id=3,FirstName="saitt3",LastName="kayarr3"}
        };
        // GET: api/<GuestController>
        [HttpGet]
        public IEnumerable<GuestModel> Get()
        {
            return guests;
        }

        // GET api/<GuestController>/5
        [HttpGet("{id}")]
        public GuestModel Get(int id)
        {
            return guests.Where(g=>g.Id==id).FirstOrDefault();
        }

        // POST api/<GuestController>
        [HttpPost]
        public void Post([FromBody] GuestModel value)
        {
            guests.Add(value);
        }

        // PUT api/<GuestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GuestModel value)
        {
            guests.Remove(guests.Where(g => g.Id == id).FirstOrDefault());
            guests.Add(value);
        }

        // DELETE api/<GuestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            guests.Remove(guests.Where(g => g.Id == id).FirstOrDefault()); 
        }
    }
}
