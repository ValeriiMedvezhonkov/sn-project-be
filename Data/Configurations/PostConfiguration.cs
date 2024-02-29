using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace sn_project_be.Data.Configurations;

public class ConfigurePosts
{
    private Guid? _id = null;
    private string _title = "";
    private string _content = "";

    public Guid Id
    {
        get => _id ?? Guid.NewGuid();
        set => _id = value;
    }

    public string Title
    {
        get => _title;
        set => _title = value;
    }

    public string Content
    {
        get => _content;
        set => _content = value;
    }

    public DateTime CreatedAt => DateTime.UtcNow.AddDays(new Random().Next(-400, 0));
    public DateTime UpdatedAt => DateTime.UtcNow;
}

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    private readonly SnDbContext _context;
    private readonly IMapper _mapper;
    public PostConfiguration(SnDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public void Configure(EntityTypeBuilder<Post> builder)
    {
        var data = new ConfigurePosts[]
        {
            new ConfigurePosts
            {
                Title = "Integer urna. Vivamus molestie dapibus ligula. Aliquam erat",
                Content = "rutrum eu, ultrices sit amet, risus. Donec nibh enim, gravida sit amet, dapibus id,"
            },
            new ConfigurePosts
            {
                Title = "dictum sapien. Aenean massa. Integer",
                Content =
                    "ipsum. Suspendisse sagittis. Nullam vitae diam. Proin dolor. Nulla semper tellus id nunc interdum feugiat. Sed nec metus facilisis lorem tristique aliquet. Phasellus fermentum convallis ligula."
            },
            new ConfigurePosts
            {
                Title = "tincidunt aliquam arcu. Aliquam",
                Content =
                    "Quisque nonummy ipsum non arcu. Vivamus sit amet risus. Donec egestas. Aliquam nec enim. Nunc ut"
            },
            new ConfigurePosts
            {
                Title = "est, congue a, aliquet",
                Content = "lobortis ultrices. Vivamus rhoncus. Donec est."
            },
            new ConfigurePosts
            {
                Title = "vitae",
                Content =
                    "et, commodo at, libero. Morbi accumsan laoreet ipsum. Curabitur consequat, lectus sit amet luctus vulputate, nisi sem semper erat, in consectetuer ipsum nunc id enim. Curabitur massa. Vestibulum accumsan neque et nunc."
            },
            new ConfigurePosts
            {
                Title = "arcu. Sed et libero. Proin mi. Aliquam gravida mauris",
                Content =
                    "sem. Nulla interdum. Curabitur dictum. Phasellus in felis. Nulla tempor augue ac ipsum. Phasellus vitae mauris sit amet lorem semper auctor. Mauris vel turpis. Aliquam adipiscing"
            },
            new ConfigurePosts
            {
                Title = "nibh vulputate",
                Content =
                    "vehicula risus. Nulla eget metus eu erat semper rutrum. Fusce dolor quam, elementum at, egestas a, scelerisque sed, sapien. Nunc pulvinar arcu et pede. Nunc sed orci lobortis augue scelerisque mollis. Phasellus libero mauris, aliquam eu, accumsan"
            },
            new ConfigurePosts
            {
                Title = "ut, sem. Nulla interdum. Curabitur dictum. Phasellus in",
                Content =
                    "at pede. Cras vulputate velit eu sem. Pellentesque ut ipsum ac mi eleifend egestas. Sed pharetra, felis eget varius ultrices, mauris ipsum porta elit, a feugiat tellus lorem eu metus. In lorem. Donec elementum, lorem ut aliquam iaculis, lacus"
            },
            new ConfigurePosts
            {
                Title = "ac sem ut dolor",
                Content = "ac facilisis"
            },
            new ConfigurePosts
            {
                Title = "vestibulum massa rutrum magna. Cras convallis convallis dolor.",
                Content =
                    "augue. Sed molestie. Sed id risus quis diam luctus lobortis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos hymenaeos. Mauris ut quam vel sapien imperdiet ornare. In faucibus."
            },
            new ConfigurePosts
            {
                Title = "Nullam suscipit, est ac facilisis facilisis, magna tellus faucibus leo,",
                Content = "sapien. Aenean massa. Integer vitae nibh. Donec est mauris, rhoncus id, mollis nec,"
            },
            new ConfigurePosts
            {
                Title = "ac mattis",
                Content =
                    "id, ante. Nunc mauris sapien, cursus in, hendrerit consectetuer, cursus et, magna. Praesent interdum ligula eu enim. Etiam imperdiet dictum magna. Ut tincidunt orci quis lectus. Nullam suscipit, est ac facilisis facilisis, magna tellus"
            },
            new ConfigurePosts
            {
                Title = "diam at pretium aliquet, metus",
                Content =
                    "vitae, aliquet nec, imperdiet nec, leo. Morbi neque tellus, imperdiet non, vestibulum nec, euismod in, dolor. Fusce feugiat. Lorem ipsum dolor sit"
            },
            new ConfigurePosts
            {
                Title = "nulla. Integer urna. Vivamus molestie dapibus ligula.",
                Content =
                    "Mauris quis turpis vitae purus gravida sagittis. Duis gravida. Praesent eu nulla at sem molestie sodales. Mauris blandit enim consequat purus. Maecenas libero est, congue a, aliquet vel, vulputate eu, odio. Phasellus at augue id ante dictum cursus. Nunc"
            },
            new ConfigurePosts
            {
                Title = "at sem molestie sodales. Mauris blandit enim",
                Content =
                    "mauris ut mi. Duis risus odio, auctor vitae, aliquet nec, imperdiet nec, leo. Morbi neque tellus,"
            },
            new ConfigurePosts
            {
                Title = "neque. Morbi quis urna. Nunc quis arcu vel quam",
                Content =
                    "diam vel arcu. Curabitur ut odio vel est tempor bibendum. Donec felis orci, adipiscing non, luctus sit amet, faucibus ut, nulla. Cras eu tellus eu augue porttitor interdum. Sed auctor odio"
            },
            new ConfigurePosts
            {
                Title = "diam. Pellentesque",
                Content =
                    "arcu. Morbi sit amet massa. Quisque porttitor eros nec tellus. Nunc lectus pede, ultrices a, auctor non, feugiat nec, diam. Duis"
            },
            new ConfigurePosts
            {
                Title = "ridiculus mus. Proin vel",
                Content = "eu odio tristique pharetra. Quisque ac libero nec ligula consectetuer rhoncus."
            },
            new ConfigurePosts
            {
                Title = "ridiculus mus. Proin vel nisl. Quisque fringilla euismod",
                Content =
                    "vestibulum massa rutrum magna. Cras convallis convallis dolor. Quisque tincidunt pede ac urna. Ut tincidunt vehicula risus. Nulla eget metus eu erat semper rutrum. Fusce dolor quam,"
            },
            new ConfigurePosts
            {
                Title = "Nulla tincidunt, neque vitae",
                Content = "pretium neque. Morbi quis urna."
            }
        };

        foreach (var obj in data)
        {
            var post = _mapper.Map<Post>(obj);
            builder.HasData(post);
        }
    }
}