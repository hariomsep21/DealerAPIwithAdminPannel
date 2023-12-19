using AdminPannel_API.Models;
using AdminPannel_API.Models.DTO;
using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPannel_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StateAPIController : ControllerBase
    {


        private readonly DealerApifinalContext _db;
        private readonly IMapper _mapper;

        public StateAPIController(DealerApifinalContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
       
        public async Task<ActionResult<IEnumerable<StateDTO>>> GetStateDetails()
        {
            try
            {
                var statedetails = await _db.Statetbls.ToListAsync();

                if (statedetails == null || statedetails.Count == 0)
                {
                    // Return 404 Not Found if no data is found
                    return NotFound("No account details found");
                }

                // Use AutoMapper to map the entities to DTO
                var StatesDto = _mapper.Map<IEnumerable<StateDTO>>(statedetails);

                return Ok(StatesDto);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as appropriate for your application

                // Return 500 Internal Server Error
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
