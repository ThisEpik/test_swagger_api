using Microsoft.AspNetCore.Mvc;
using test_swagger_api.Models;

namespace test_swagger_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {

        [HttpGet(Name = "GetPersonById")]
        public Person Get(int id)
        {
            return new Person(id: id, name: "Bob", age: 35);
        }
    }
}
