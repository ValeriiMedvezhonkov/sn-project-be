namespace sn_project_be.Data;

public enum FriendshipStatus
{
    InvitationSent,
    Accepted,
    Canceled
}

public class Friendship
{
    public Guid FriendshipId { get; set; }

    public Guid SenderUserId { get; set; }
    public ApiUser SenderUser { get; set; }

    public Guid ReceiverUserId { get; set; }
    public ApiUser ReceiverUser { get; set; }
    
    public FriendshipStatus Status { get; set; }
}