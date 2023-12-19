
using AdminPannel_API.Models;
using AdminPannel_API.Models.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPannel_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserInfoAPIController : ControllerBase
    {
        private readonly DealerApifinalContext _db;
        private readonly IMapper _mapper;

        public UserInfoAPIController(DealerApifinalContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;

        }


        [HttpGet("Getdetails")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<UserInfoDTO>>> GetUserInfoSupport()
        {
            try
            {
                var userInfoDetails = await _db.Userstbls
                    .ToListAsync();

                if (userInfoDetails == null || userInfoDetails.Count == 0)
                {
                    // Return 404 Not Found if no data is found
                    return NotFound("No user details found");
                }

                // Use AutoMapper to map the entities to DTO
                var userInfoDTO = _mapper.Map<IEnumerable<UserInfoDTO>>(userInfoDetails);

                return Ok(userInfoDTO);
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