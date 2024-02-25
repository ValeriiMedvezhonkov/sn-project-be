using AutoMapper;
using Microsoft.EntityFrameworkCore;
using sn_project_be.Core.Exceptions;
using sn_project_be.Core.Interfaces;
using sn_project_be.Core.Models.Posts;
using sn_project_be.Core.Models.Users;
using sn_project_be.Data;

namespace sn_project_be.Core.Repository;

public class PostManager: GenericRepository<Post>, IPostManager
{
    private readonly IFileService _fileService;
    private readonly IMapper _mapper;
    private readonly SnDbContext _context;

    public PostManager(SnDbContext context, IMapper mapper, IFileService fileService) : base(context, mapper)
    {
        _context = context;
        _fileService = fileService;
        _mapper = mapper;
    }

    public async Task<string> CreatePost(CreatePost createPost, string userId)
    {
        var post = await AddAsync<CreatePost, Post>(createPost);
        var userPost = new User_Post()
        {
            Id = Guid.NewGuid(),
            PostId = post.Id,
            UserId = new Guid(userId)
        };
        _context.UserPosts.Add(userPost);
        await _context.SaveChangesAsync();
        return post.Id.ToString();
    }

    public List<PostWithUserData> GetUserPosts(string userId)
    {
        // var author = await _context.Users.Where(n => n.Id == new Guid(userId))
        //     .Select(n => n.UserPosts.Select(userPost => userPost.Post).ToList()).FirstOrDefaultAsync();
        // return author;
        var posts = _context.UserPosts
            .Where(a => a.UserId == new Guid(userId)).Select(sel => new PostWithUserData()
            {
                PostId = sel.Post.Id,
                Title = sel.Post.Title,
                Content = sel.Post.Content,
                UserId = sel.User.Id,
                FirstName = sel.User.FirstName,
                LastName = sel.User.LastName
            }).ToList();
        return posts;
    }

    public async Task<PostWithUserData?> GetUserPost(string postId)
    {
        var post = await _context.Posts.Where(q => q.Id == new Guid(postId))
            .Select(post => post.UserPosts.Select(sel => new PostWithUserData()
            {
                PostId = post.Id,
                Title = post.Title,
                Content = post.Content,
                UserId = sel.User.Id,
                FirstName = sel.User.FirstName,
                LastName = sel.User.LastName
            }).SingleOrDefault()).SingleOrDefaultAsync();
        
        return post;
    }
}
