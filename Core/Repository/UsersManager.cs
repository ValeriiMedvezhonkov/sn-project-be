using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using sn_project_be.Core.Exceptions;
using sn_project_be.Core.Interfaces;
using sn_project_be.Core.Models.Files;
using sn_project_be.Core.Models.Users;
using sn_project_be.Data;

namespace sn_project_be.Core.Repository;

public class UsersManager : GenericRepository<ApiUser>, IUserManager
{
    private readonly UserManager<ApiUser> _userManager;
    private readonly IMapper _mapper;
    private readonly IFileService _fileService;
    private readonly SnDbContext _context;

    public UsersManager(
        SnDbContext context,
        IMapper mapper,
        UserManager<ApiUser> userManager,
        IFileService fileService
    ) : base(context, mapper)
    {
        _mapper = mapper;
        _userManager = userManager;
        _fileService = fileService;
        _context = context;
    }

    public async Task<GetUserDto> UpdateUser(Guid id, UpdateUserDto user)
    {
        var userUpd = await _userManager.FindByIdAsync(id.ToString());
        if (userUpd == null)
        {
            throw new NotFoundException(nameof(ApiUser), id);
        }

        _mapper.Map(user, userUpd);
        var result = await _userManager.UpdateAsync(userUpd);

        if (result.Errors.Any())
        {
            throw new BadRequestException("Some error while User updating");
        }

        var userToRet = await GetAsync<GetUserDto>(id);
        return userToRet;
    }

    public async Task AddFriend(Guid senderId, Guid receiverId)
    {
        var senderUser = await _userManager.FindByIdAsync(senderId.ToString());
        var receiverUser = await _userManager.FindByIdAsync(receiverId.ToString());
        if (senderUser == null)
        {
            throw new NotFoundException("ApiUser", senderId);
        }

        if (receiverUser == null)
        {
            throw new NotFoundException("ApiUser", receiverId);
        }

        var friendship = new Friendship
        {
            SenderUserId = senderUser.Id,
            ReceiverUserId = receiverUser.Id,
            Status = FriendshipStatus.InvitationSent
        };
        _context.Friendships.Add(friendship);
        await _context.SaveChangesAsync();
    }

    public async Task AcceptFriendship(Guid myId, Guid friendId)
    {
        var existingInvitation = _context.Friendships.FirstOrDefault(f =>
            (f.SenderUserId == myId && f.ReceiverUserId == friendId) ||
            (f.SenderUserId == friendId && f.ReceiverUserId == myId));

        if (existingInvitation is not { Status: FriendshipStatus.InvitationSent })
        {
            throw new NotFoundException("Friendship", friendId);
        }

        // Accept the invitation
        existingInvitation.Status = FriendshipStatus.Accepted;
        await _context.SaveChangesAsync();
    }

    public async Task DeclineFriendship(Guid myId, Guid friendId)
    {
        var existingInvitation = _context.Friendships.FirstOrDefault(f =>
            (f.SenderUserId == myId && f.ReceiverUserId == friendId) ||
            (f.SenderUserId == friendId && f.ReceiverUserId == myId));

        if (existingInvitation is not { Status: FriendshipStatus.InvitationSent })
        {
            throw new NotFoundException("Friendship", friendId);
        }

        existingInvitation.Status = FriendshipStatus.Canceled;
        await _context.SaveChangesAsync();
    }

    public async Task<List<ApiUser>> GetAllFriends(Guid myId)
    {
        var friends = await _context.Friendships
            .Where(f =>
                (f.SenderUserId == myId || f.ReceiverUserId == myId) &&
                f.Status == FriendshipStatus.Accepted)
            .Select(f =>
                f.SenderUserId == myId ? f.ReceiverUser : f.SenderUser)
            .ToListAsync();
        return friends;
    }

    public async Task<List<ApiUser>> GetAllFriendshipInvitations(Guid userId)
    {
        var friends = await _context.Friendships.Where(f =>
            f.ReceiverUserId == userId && f.Status == FriendshipStatus.InvitationSent
        ).Select(f => f.SenderUser).ToListAsync();
        return friends;
    }

    public async Task<string> UpdateProfilePic(Guid userId, FileModel model)
    {
        var userUpd = await _userManager.FindByIdAsync(userId.ToString());
        if (userUpd == null)
        {
            throw new NotFoundException(nameof(ApiUser), userId);
        }

        var profilePicUrl = await _fileService.UploadProfilePicture(model);
        userUpd.ProfilePicUrl = profilePicUrl;
        var result = await _userManager.UpdateAsync(userUpd);
        if (result.Errors.Any())
        {
            throw new BadRequestException("Some error while User updating");
        }

        return profilePicUrl;
    }
}