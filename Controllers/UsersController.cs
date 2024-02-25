using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sn_project_be.Core.Exceptions;
using sn_project_be.Core.Interfaces;
using sn_project_be.Core.Models.Files;
using sn_project_be.Core.Models.Users;
using sn_project_be.Core.Pagination;
using sn_project_be.Data;

namespace sn_project_be.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : BaseController
{
    private readonly IUserManager _userManager;
    public UsersController(IUserManager userManager)
    {
        _userManager = userManager;
    }
    
    // GET: api/Users/
    [HttpGet]
    public async Task<ActionResult<List<ApiUser>>> GetUsers([FromQuery] QueryStringParameters paginationParameters)
    {
        var users = await _userManager.GetAllAsync<GetAllUsersDto>(paginationParameters);
        return Ok(users);
    }
    
    [Authorize]
    [HttpGet]
    [Route("/me")]
    public async Task<ActionResult<GetUserDto>> Me()
    {
        var user = await _userManager.GetAsync<GetUserDto>(new Guid(CurrentUserId!));
        return Ok(user);
    }

    // GET: api/Users/{id}
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<GetUserDto>> GetUser(Guid id)
    {
        var user = await _userManager.GetAsync<GetUserDto>(id);
        return user;
    }
    
    [Authorize]
    [HttpPut("{id:guid}")]
    public async Task<ActionResult<GetUserDto>> UpdateProfile(Guid id, UpdateUserDto user)
    {
        if (CurrentUserId != id.ToString())
        {
            throw new BadRequestException("You trying to update another User");
        }
        
        var userRet = await _userManager.UpdateUser(id, user);
        return Ok(userRet);
    }
    
    [Authorize]
    [HttpPut("/update-profile-pic")]
    public async Task<ActionResult> UpdateProfile([FromForm] FileModel model)
    {
        var profilePicUrl = await _userManager.UpdateProfilePic(new Guid(CurrentUserId!), model);
        return Ok(profilePicUrl);
    }
    
    [Authorize]
    [HttpPut("/add-friend/{friendId:guid}")]
    public async Task<ActionResult> AddFriend(Guid friendId)
    {
        await _userManager.AddFriend(new Guid(CurrentUserId!), friendId);
        return Ok();
    }
    
    [Authorize]
    [HttpPut("/accept-friend/{friendId:guid}")]
    public async Task<ActionResult> AcceptFriendship(Guid friendId)
    {
        await _userManager.AcceptFriendship(new Guid(CurrentUserId!), friendId);
        return Ok();
    }
    
    [Authorize]
    [HttpPut("/decline-friend/{friendId:guid}")]
    public async Task<ActionResult> DeclineFriendship(Guid friendId)
    {
        await _userManager.DeclineFriendship(new Guid(CurrentUserId!), friendId);
        return Ok();
    }

    [Authorize]
    [HttpGet("/get-friends/{userId:guid}")]
    public async Task<ActionResult<List<ApiUser>>> GetAllFriends(Guid userId)
    {
        var friends = await _userManager.GetAllFriends(userId);
        return Ok(friends);
    }
    
    [Authorize]
    [HttpGet("/friendship-invitations/{userId:guid}")]
    public async Task<ActionResult<List<ApiUser>>> GetAllFriendshipInvitations(Guid userId)
    {
        var friends = await _userManager.GetAllFriendshipInvitations(userId);
        return Ok(friends);
    }
}
