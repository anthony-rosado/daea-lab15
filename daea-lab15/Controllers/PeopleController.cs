using daea_lab15.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace daea_lab15.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PeopleController : Controller
    {
        [Authorize]
        [HttpGet(Name = "Get")]
        public IEnumerable<PersonResponse> Get()
        {
            List<PersonResponse> people = new List<PersonResponse>();

            for (int i = 0; i < 10; i++) {
                people.Add(new PersonResponse { 
                    FirstName = "Person " + i.ToString(),
                    LastName = i.ToString(),
                });
            }

            return people;
        }
    }
}
