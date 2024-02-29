using System.Dynamic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sn_project_be.Core.Exceptions;
using sn_project_be.Core.Interfaces;
using sn_project_be.Core.Models.Posts;
using sn_project_be.Core.Models.Users;
using sn_project_be.Core.Pagination;
using sn_project_be.Data;

namespace sn_project_be.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostController : BaseController
{
    private readonly IPostManager _postManager;
    
    public PostController(IPostManager postManager)
    {
        _postManager = postManager;
    }
    
    // GET: api/Posts/
    [HttpGet]
    public async Task<ActionResult<PaginationResponse<Post>>> GetPosts([FromQuery] PostParameters paginationParameters)
    {
        var posts = await _postManager.GetAllAsync<Post, GetAllPostsFilterParams, PostParameters>(paginationParameters);
        return Ok(posts);
    }

    [Authorize]
    [HttpPost]
    public async Task<ActionResult<Post>> CreatePost(CreatePost createPost)
    {
        var post = await _postManager.CreatePost(createPost, CurrentUserId!);
        return Ok(post);
    }
    
    [HttpGet]
    [Route("user-posts/{userId:guid}")]
    public ActionResult<List<Post>> GetUserPosts(Guid userId)
    {
        var posts =  _postManager.GetUserPosts(userId.ToString());
        if (posts == null)
        {
            throw new NotFoundException("Posts", userId.ToString()); 
        }
        return Ok(posts);
    }
    
    [HttpGet]
    [Route("user-post/{postId:guid}")]
    public async Task<PostWithUserData> GetPost(Guid postId)
    {
        var post = await _postManager.GetUserPost(postId.ToString());
        if (post == null)
        {
            throw new NotFoundException("Posts", postId.ToString()); 
        }
        return post;
    }
}
