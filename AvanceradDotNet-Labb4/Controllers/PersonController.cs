using AvanceradDotNet_Labb4.Models;
using AvanceradDotNet_Labb4.Services;
using Microsoft.AspNetCore.Mvc;

namespace AvanceradDotNet_Labb4.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonRepository<Person> _personRepository;
        public PersonController(IPersonRepository<Person> personRepository)
        {
            this._personRepository = personRepository;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllPersons()
        {
            try
            {
                return Ok(await _personRepository.GetAll());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error fetching data from database");
            }
        }
        [HttpGet("GetInterests/{id:int}")]
        public async Task<ActionResult<Person>> GetInterestsbyID(int id)
        {
            return Ok(await _personRepository.GetInterests(id));
        }
        [HttpGet("GetLinks/{id:int}")]
        public async Task<ActionResult<Person>> GetLinksbyID(int id)
        {
            return Ok(await _personRepository.GetLinks(id));
        }
    }
}
