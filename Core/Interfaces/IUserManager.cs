using Microsoft.AspNetCore.Mvc;
using sn_project_be.Core.Models.Files;
using sn_project_be.Core.Models.Users;
using sn_project_be.Data;

namespace sn_project_be.Core.Interfaces;

public interface IUserManager : IGenericRepository<ApiUser>
{
    Task<GetUserDto> UpdateUser(Guid id, UpdateUserDto user);

    Task AddFriend(Guid senderId, Guid receiverId);
    Task AcceptFriendship(Guid myId, Guid friendId);
    Task DeclineFriendship(Guid myId, Guid friendId);
    Task<List<ApiUser>> GetAllFriends(Guid myId);
    Task<List<ApiUser>> GetAllFriendshipInvitations(Guid myId);
    Task<string> UpdateProfilePic(Guid userId, [FromForm] FileModel model);
}
