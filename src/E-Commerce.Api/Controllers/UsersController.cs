using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Users;
using E_Commerce.Service.DTOs.Users;
using E_Commerce.Service.Interfases;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<UserFullViewDto>> GetUser(long userId)
        {
            return Ok(await _userService.GetAsync(user => user.Id == userId));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers([FromQuery] PaginationParams parameters)
        {
            return Ok(await _userService.GetAllAsync(parameters: parameters));
        }

        [HttpPut("{userId}")]
        public async Task<ActionResult<User>> PutUser(long userId, UserPutDto dto)
        {
            return Ok(await _userService.UpdateAsync(userId, dto));
        }

        [HttpPatch("{userId}")]
        public async Task<ActionResult<User>> PatchUser(long userId, UserPatchDto dto)
        {
            return Ok(await _userService.UpdateAsync(userId, dto));
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<bool>> DeleteAsync([FromRoute(Name = "Id")] long id)
        => Ok(await _userService.DeleteAsync(p => p.Id == id));

    }
}
