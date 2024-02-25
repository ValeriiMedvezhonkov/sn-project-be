using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace sn_project_be.Data.Configurations;

public class ConfigureUsers
{
    private Guid? _id = null;
    private string _userName = "";
    private string _firstName = "";
    private string _lastName = "";
    private string _email = "";
    private bool? _emailConfirmed;
    private bool? _phoneNumberConfirmed;
    
    public Guid Id
    {
        get => _id ?? Guid.NewGuid();
        set => _id = value;
    }
    
    public string UserName
    {
        get => _userName;
        set => _userName = value;
    }

    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }
    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }
    public string Email
    {
        get => _email;
        set => _email = value;
    }
    public string NormalizedUserName => _userName.ToUpper();
    public string NormalizedEmail => _email.ToUpper();

    public bool EmailConfirmed
    {
        get => _emailConfirmed ?? true;
        set => _emailConfirmed = value;
    }
    
    public bool PhoneNumberConfirmed {
        get => _phoneNumberConfirmed ?? true;
        set => _phoneNumberConfirmed = value;
    }

    public string SecurityStamp => Guid.NewGuid().ToString("D");

    public DateTime CreatedAt => DateTime.UtcNow;
    public DateTime UpdatedAt => DateTime.UtcNow;
}


public interface IUserConfigurationMaximaze
{
    public void Configure(EntityTypeBuilder<ApiUser> builder);
}
public class UserConfigurationMaximaze : IEntityTypeConfiguration<ApiUser>, IUserConfigurationMaximaze
{
    private readonly SnDbContext _context;
    private readonly IMapper _mapper;
    public UserConfigurationMaximaze(SnDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public void Configure(EntityTypeBuilder<ApiUser> builder)
    {
        var data = new ConfigureUsers[]
        {
            new ConfigureUsers
            {
                FirstName = "Yuli",
                LastName = "Hinton",
                Email = "porttitor.scelerisque.neque@google.org",
                UserName = "Gannon",
            },
            new ConfigureUsers
            {
                FirstName = "Maisie",
                LastName = "Lawrence",
                Email = "ut.odio@yahoo.couk",
                UserName = "Arden",
            },
            new ConfigureUsers
            {
                FirstName = "Bianca",
                LastName = "Baxter",
                Email = "pede.nec@outlook.com",
                UserName = "Bo",
            },
            new ConfigureUsers
            {
                FirstName = "George",
                LastName = "Weber",
                Email = "risus.in@icloud.net",
                UserName = "Hu",
            },
            new ConfigureUsers
            {
                FirstName = "MacKenzie",
                LastName = "Burnett",
                Email = "purus.mauris@google.ca",
                UserName = "Iris",
            },
            new ConfigureUsers
            {
                FirstName = "Kiara",
                LastName = "Perez",
                Email = "vitae@yahoo.net",
                UserName = "Maggie",
            },
            new ConfigureUsers
            {
                FirstName = "Holmes",
                LastName = "Burton",
                Email = "fusce.diam.nunc@yahoo.org",
                UserName = "Fredericka",
            },
            new ConfigureUsers
            {
                FirstName = "Ralph",
                LastName = "Valdez",
                Email = "et.netus.et@outlook.edu",
                UserName = "Vladimir",
            },
            new ConfigureUsers
            {
                FirstName = "Victoria",
                LastName = "Weaver",
                Email = "ipsum.curabitur@outlook.com",
                UserName = "Cailin",
            },
            new ConfigureUsers
            {
                FirstName = "Ursa",
                LastName = "Pickett",
                Email = "blandit.congue@protonmail.ca",
                UserName = "Amena",
            },
            new ConfigureUsers
            {
                FirstName = "Amity",
                LastName = "Hess",
                Email = "non.vestibulum@outlook.ca",
                UserName = "Debra",
            },
            new ConfigureUsers
            {
                FirstName = "Cooper",
                LastName = "Briggs",
                Email = "metus.in@protonmail.edu",
                UserName = "Kaye",
            },
            new ConfigureUsers
            {
                FirstName = "Brynne",
                LastName = "Johnson",
                Email = "quisque@hotmail.edu",
                UserName = "Timon",
            },
            new ConfigureUsers
            {
                FirstName = "Bruno",
                LastName = "Hurst",
                Email = "sed.molestie@icloud.couk",
                UserName = "Bert",
            },
            new ConfigureUsers
            {
                FirstName = "Brandon",
                LastName = "Waller",
                Email = "integer.vulputate@yahoo.com",
                UserName = "Phillip",
            },
            new ConfigureUsers
            {
                FirstName = "Gage",
                LastName = "Goodman",
                Email = "sed.nec@hotmail.org",
                UserName = "Leah",
            },
            new ConfigureUsers
            {
                FirstName = "Melissa",
                LastName = "Rosa",
                Email = "turpis.in.condimentum@icloud.edu",
                UserName = "Unity",
            },
            new ConfigureUsers
            {
                FirstName = "Serina",
                LastName = "Sparks",
                Email = "suscipit.nonummy@yahoo.couk",
                UserName = "Abbot",
            },
            new ConfigureUsers
            {
                FirstName = "Nyssa",
                LastName = "Forbes",
                Email = "urna@outlook.net",
                UserName = "Hayes",
            },
            new ConfigureUsers
            {
                FirstName = "Jelani",
                LastName = "Conrad",
                Email = "amet.risus.donec@hotmail.ca",
                UserName = "Kay"
            }
        };
        
        foreach (var obj in data)
        {
            var apiUser = _mapper.Map<ApiUser>(obj);
            var adminPassword = new PasswordHasher<ApiUser>();
            var adminHashedPassword = adminPassword.HashPassword(apiUser, "from1to0");
            apiUser.PasswordHash = adminHashedPassword;
            builder.HasData(apiUser);
        }
    }
}