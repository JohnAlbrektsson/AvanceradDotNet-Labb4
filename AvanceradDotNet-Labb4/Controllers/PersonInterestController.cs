using AvanceradDotNet_Labb4.Models;
using AvanceradDotNet_Labb4.Services;
using Microsoft.AspNetCore.Mvc;

namespace AvanceradDotNet_Labb4.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class PersonInterestController : ControllerBase
    {
        private IPersonInterestRepo<PersonInterest> _personInterestRepo;
        public PersonInterestController(IPersonInterestRepo<PersonInterest> personInterestRepo)
        {
            _personInterestRepo = personInterestRepo;
        }

     
        [HttpPost("AddLinkInterestandPerson")]
        public async Task<IActionResult> AddLinktoInterestandPerson(PersonInterest newEntity)
        {
            try
            {
                if (newEntity == null)
                {
                    return BadRequest();
                }
                var result = new PersonInterest();
                result.PersonID = newEntity.PersonID;
                result.InterestID = newEntity.InterestID;
                result.LinkID = newEntity.LinkID;
                return Ok(await _personInterestRepo.Add(result));
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,"Error ");
            }
        }
        [HttpPost("AddInteresttoPerson")]
        public async Task<IActionResult> AddInteresttoPerson(PersonInterestDto newEntity)
        {
            try
            {
                if (newEntity == null)
                {
                    return BadRequest();
                }
                var result = new PersonInterest();
                result.PersonID = newEntity.PersonID;
                result.InterestID = newEntity.InterestID;
                result.LinkID = 1;
                return Ok(await _personInterestRepo.Add(result));
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<PersonInterest>> Get(int id)
        {
            try
            {
                var result = await _personInterestRepo.Get(id);
                if(result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        
    }
}
