using APIHomeWork.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIHomeWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        // GET: api/<GreetingsController>
        [HttpGet]
        public string Get(string firstName, string lastName)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstName,
                LastName = lastName
            };

            return  $"Hello {person.FirstName} {person.LastName}" ;
        }

        // GET api/<GreetingsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GreetingsController>
        [HttpPost]
        public string Post([FromBody] PersonModel person)
        {
            return $"Hello {person.FirstName} {person.LastName}";
        }

        // PUT api/<GreetingsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GreetingsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
