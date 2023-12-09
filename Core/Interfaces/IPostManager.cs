using sn_project_be.Core.Models.Posts;
using sn_project_be.Core.Models.Users;
using sn_project_be.Data;

namespace sn_project_be.Core.Interfaces;

public interface IPostManager: IGenericRepository<Post>
{
    Task<string> CreatePost(CreatePost createPost, string userId);
    List<PostWithUserData> GetUserPosts(string userId);
    Task<PostWithUserData?> GetUserPost(string postId);
}
