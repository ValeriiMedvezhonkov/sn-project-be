using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sn_project_be.Migrations
{
    /// <inheritdoc />
    public partial class UserMultipleInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    ProfilePicUrl = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    FriendshipId = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReceiverUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendships", x => x.FriendshipId);
                    table.ForeignKey(
                        name: "FK_Friendships_AspNetUsers_ReceiverUserId",
                        column: x => x.ReceiverUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Friendships_AspNetUsers_SenderUserId",
                        column: x => x.SenderUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    PostId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPosts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPosts_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("bd7a7276-168d-40c4-88c6-fa809993b6e1"), null, "Administrator", "ADMINISTRATOR" },
                    { new Guid("cae420fb-001a-4df1-9ca0-dbd841ef22ac"), null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicUrl", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("04ca7b0a-b838-4b33-a001-cbfa49c40468"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 484, DateTimeKind.Utc).AddTicks(7240), "risus.in@icloud.net", true, "George Weber", "Marsden Contreras", false, null, "RISUS.IN@ICLOUD.NET", "HU", "AQAAAAIAAYagAAAAEImuPvIRiBdcJaqC8Lfi6byQwW5hI3PCWowMrQTCR85h+tJMqmVCJgRSJI6ljrkguA==", null, true, null, "042abb75-eb48-48ff-8be7-dd30e9cfbdd0", false, new DateTime(2024, 2, 24, 17, 5, 26, 484, DateTimeKind.Utc).AddTicks(7240), "Hu" },
                    { new Guid("115e991b-dbea-43f6-aa20-b2045fd2d36d"), 0, null, new DateTime(2024, 2, 24, 17, 5, 27, 76, DateTimeKind.Utc).AddTicks(850), "suscipit.nonummy@yahoo.couk", true, "Serina Sparks", "Vanna Dyer", false, null, "SUSCIPIT.NONUMMY@YAHOO.COUK", "ABBOT", "AQAAAAIAAYagAAAAEMEkqu8hVzBIoJTyHfwoUNqaJWOhjsXpbiHNpZb9QKZ0m2kWk11WTeBbkwe8JO9ASQ==", null, true, null, "aa9959ab-28ff-436e-b0e6-973470f20447", false, new DateTime(2024, 2, 24, 17, 5, 27, 76, DateTimeKind.Utc).AddTicks(850), "Abbot" },
                    { new Guid("3c08cfab-d72e-450a-8c64-1f82ab7c16f4"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 569, DateTimeKind.Utc).AddTicks(3480), "vitae@yahoo.net", true, "Kiara Perez", "Desirae Hoover", false, null, "VITAE@YAHOO.NET", "MAGGIE", "AQAAAAIAAYagAAAAEHDpF3oZK/68Pt++FdcQY3RNEl/ehW4NKpLHdRyq6u3ft0gc4lFKWjCW1m+HsRIi6A==", null, true, null, "8dd3f4c6-e7a9-4dd9-860a-5ee1f776e6c5", false, new DateTime(2024, 2, 24, 17, 5, 26, 569, DateTimeKind.Utc).AddTicks(3480), "Maggie" },
                    { new Guid("3daa663d-0bdf-43ea-8f0e-ab3ecfccb4d1"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 737, DateTimeKind.Utc).AddTicks(3800), "blandit.congue@protonmail.ca", true, "Ursa Pickett", "Dara Buckner", false, null, "BLANDIT.CONGUE@PROTONMAIL.CA", "AMENA", "AQAAAAIAAYagAAAAEEhnIcnrtcOVGGa4HvWVX6zvSZnyKyAlGn+p4maFxM+KxRKZMnXPbRCgBMbpqA3p5g==", null, true, null, "4b4c988c-7d2c-4727-847a-4627fbde81ea", false, new DateTime(2024, 2, 24, 17, 5, 26, 737, DateTimeKind.Utc).AddTicks(3800), "Amena" },
                    { new Guid("5a49c82b-4f25-4e93-84e7-a24df464a72b"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 316, DateTimeKind.Utc).AddTicks(8920), "medvezhonkov285@gmail.com", true, "Valerii", "Medvezhonkov", false, null, "MEDVEZHONKOV285@GMAIL.COM", "AKIHITO", "AQAAAAIAAYagAAAAENlD0kne1ARrBsG1Hp9eYcwBcuuLxPLYi4cl8SZ3XGUCdB9VtQLTCTwrYPFVvK0u2g==", null, true, null, "d9471b99-af97-4d86-8233-0905712b5391", false, new DateTime(2024, 2, 24, 17, 5, 26, 316, DateTimeKind.Utc).AddTicks(8920), "Akihito" },
                    { new Guid("5fbed1ed-1d3b-4b10-9ff7-4a2a816ad3e7"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 949, DateTimeKind.Utc).AddTicks(830), "integer.vulputate@yahoo.com", true, "Brandon Waller", "Brenden Brady", false, null, "INTEGER.VULPUTATE@YAHOO.COM", "PHILLIP", "AQAAAAIAAYagAAAAEOageyKTZHoCtlwfA80RrHcilj+I/ziQ8Cw5tR5gFN4XvaIV8A1suCdPNcOnKPbMLA==", null, true, null, "2d95de97-82ab-4508-b676-153c2f495ff1", false, new DateTime(2024, 2, 24, 17, 5, 26, 949, DateTimeKind.Utc).AddTicks(840), "Phillip" },
                    { new Guid("6c5f6c63-741d-4439-86f8-03e7e1384b44"), 0, null, new DateTime(2024, 2, 24, 17, 5, 27, 160, DateTimeKind.Utc).AddTicks(7150), "amet.risus.donec@hotmail.ca", true, "Jelani Conrad", "Stewart Blankenship", false, null, "AMET.RISUS.DONEC@HOTMAIL.CA", "KAY", "AQAAAAIAAYagAAAAEEfoCME1CJ9v7od4q68/RGu4htqtR/nZGGcTaWSCja+zTwQd4DQVzM1ZEOjVRQ6WNw==", null, true, null, "fd1bedac-9297-4035-8374-7e1f07d19b71", false, new DateTime(2024, 2, 24, 17, 5, 27, 160, DateTimeKind.Utc).AddTicks(7150), "Kay" },
                    { new Guid("757bdcc6-ce69-4d3a-b2fd-7d39d028ba4c"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 358, DateTimeKind.Utc).AddTicks(7780), "porttitor.scelerisque.neque@google.org", true, "Yuli Hinton", "Wilma Rollins", false, null, "PORTTITOR.SCELERISQUE.NEQUE@GOOGLE.ORG", "GANNON", "AQAAAAIAAYagAAAAENwFnCfhfjEDG1XNwjphjowk264tqx4ez32l1LEGQDihVBT+/hyqK2ARL1fp9TKyIQ==", null, true, null, "86f08ef1-beb4-4825-bd56-6a96218305fc", false, new DateTime(2024, 2, 24, 17, 5, 26, 358, DateTimeKind.Utc).AddTicks(7780), "Gannon" },
                    { new Guid("77d631fc-74c3-4973-bb0b-a331337df9e5"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 906, DateTimeKind.Utc).AddTicks(9510), "sed.molestie@icloud.couk", true, "Bruno Hurst", "James Bender", false, null, "SED.MOLESTIE@ICLOUD.COUK", "BERT", "AQAAAAIAAYagAAAAENnx+EZbqSr1I59OnoqsWQJMEuQtEG+NDmz1wQ9hcUK64dUK9WeactUyYpfI2jlaZw==", null, true, null, "1cd0969a-ca7c-4f76-96bc-57071e68ab38", false, new DateTime(2024, 2, 24, 17, 5, 26, 906, DateTimeKind.Utc).AddTicks(9510), "Bert" },
                    { new Guid("86a7e0c9-076a-4097-9b0f-95115bcc2ec8"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 864, DateTimeKind.Utc).AddTicks(6530), "quisque@hotmail.edu", true, "Brynne Johnson", "Colby Dominguez", false, null, "QUISQUE@HOTMAIL.EDU", "TIMON", "AQAAAAIAAYagAAAAEIBlWIgcdhDFr8ooYmzstwDcZbP/r2NVbmc1zQN4Ia7YCu0MqJBI9Xnkmho8l4LKWA==", null, true, null, "1863aa16-0ea1-4c6b-a352-c5fcbc6e2a7b", false, new DateTime(2024, 2, 24, 17, 5, 26, 864, DateTimeKind.Utc).AddTicks(6530), "Timon" },
                    { new Guid("9befd394-2945-4560-94b4-53f24c61b585"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 991, DateTimeKind.Utc).AddTicks(4920), "sed.nec@hotmail.org", true, "Gage Goodman", "Ursula Bradshaw", false, null, "SED.NEC@HOTMAIL.ORG", "LEAH", "AQAAAAIAAYagAAAAEDJh2IOaqmgLkt8/GnBod5VVl4EHpWDsRf8N1yieEF/Q2Qt3/QV6ZhMFCHB+9PYWqw==", null, true, null, "08991d57-b204-440f-86a3-89fc8b2d1efa", false, new DateTime(2024, 2, 24, 17, 5, 26, 991, DateTimeKind.Utc).AddTicks(4920), "Leah" },
                    { new Guid("a8835b47-914d-484e-8756-cada0c2b4dd8"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 779, DateTimeKind.Utc).AddTicks(8100), "non.vestibulum@outlook.ca", true, "Amity Hess", "Alice Berry", false, null, "NON.VESTIBULUM@OUTLOOK.CA", "DEBRA", "AQAAAAIAAYagAAAAECS7XIIjtKyD0h4+fclaWTBrrc9MWISFDTdSWR70uvqIAduMXGhKeL+q/ruRzFIIgw==", null, true, null, "d1aa0ee1-7496-48ce-a2d8-b151cc4302dd", false, new DateTime(2024, 2, 24, 17, 5, 26, 779, DateTimeKind.Utc).AddTicks(8100), "Debra" },
                    { new Guid("afcfc171-05f6-46bb-b323-96f56a218a98"), 0, null, new DateTime(2024, 2, 24, 17, 5, 27, 33, DateTimeKind.Utc).AddTicks(6440), "turpis.in.condimentum@icloud.edu", true, "Melissa Rosa", "Ariana Tanner", false, null, "TURPIS.IN.CONDIMENTUM@ICLOUD.EDU", "UNITY", "AQAAAAIAAYagAAAAEH7wyuxXbp+zQzqYGmG5o7YNipsBXgoZMqmvwV8GWDJCncKxgBx+Vt9NQ2aWPrYdyQ==", null, true, null, "f26e7362-2534-4cbe-abac-4bc32cfeabc1", false, new DateTime(2024, 2, 24, 17, 5, 27, 33, DateTimeKind.Utc).AddTicks(6440), "Unity" },
                    { new Guid("b74f0ac7-6d19-4d8f-bd5d-1a5d7335d3df"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 442, DateTimeKind.Utc).AddTicks(6130), "pede.nec@outlook.com", true, "Bianca Baxter", "Felix Herman", false, null, "PEDE.NEC@OUTLOOK.COM", "BO", "AQAAAAIAAYagAAAAEJ3MQBc4EtHkwFmqb/d/7SH0OSWbHVfXfPO5VHPi27N5149lfvswNocctCq51TgFbg==", null, true, null, "e2b49ed2-1c2b-4ba4-9817-2b0250e9100e", false, new DateTime(2024, 2, 24, 17, 5, 26, 442, DateTimeKind.Utc).AddTicks(6140), "Bo" },
                    { new Guid("b8210314-bb0a-4296-9ec5-a4142246cea0"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 695, DateTimeKind.Utc).AddTicks(4630), "ipsum.curabitur@outlook.com", true, "Victoria Weaver", "Paul Gomez", false, null, "IPSUM.CURABITUR@OUTLOOK.COM", "CAILIN", "AQAAAAIAAYagAAAAEJniuKIJyS+TPIYHr4322jyOTPQnPU0PpZwYPCtVwIgxPmP2/I9lbcarG+82X/iPhg==", null, true, null, "95133c3b-a159-4888-b22f-9d7c9150c695", false, new DateTime(2024, 2, 24, 17, 5, 26, 695, DateTimeKind.Utc).AddTicks(4630), "Cailin" },
                    { new Guid("bdbb9a8a-7019-4d8f-bd96-120b6cb6af2c"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 274, DateTimeKind.Utc).AddTicks(6290), "admin285@gmail.com", true, "Admin", "Admin", false, null, "ADMIN285@GMAIL.COM", "AKIHITOADMIN", "AQAAAAIAAYagAAAAELh2/5K687maZ4oOH1RFFEhFePKDMnpfXIzL+6KQX3VgdgSwf/40LRGVrsB6EzE15g==", null, true, null, "9bbc9293-c220-454b-b44c-a708780f3a87", false, new DateTime(2024, 2, 24, 17, 5, 26, 274, DateTimeKind.Utc).AddTicks(6290), "AkihitoAdmin" },
                    { new Guid("becfe44b-4347-4bc5-81f6-0cf3244ddd76"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 400, DateTimeKind.Utc).AddTicks(7910), "ut.odio@yahoo.couk", true, "Maisie Lawrence", "Kitra Soto", false, null, "UT.ODIO@YAHOO.COUK", "ARDEN", "AQAAAAIAAYagAAAAED7lDvlbbkhiCRpfE0QSoeSbDZ0LCJ1nOt3uS6Vdzrm/EWf1JQ2pQyQL7t978jZwsA==", null, true, null, "a1670304-fe7b-4d92-a1c7-5fec5aae009a", false, new DateTime(2024, 2, 24, 17, 5, 26, 400, DateTimeKind.Utc).AddTicks(7910), "Arden" },
                    { new Guid("c617bc9d-a82e-4cdb-9ed3-e20b17f530bb"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 527, DateTimeKind.Utc).AddTicks(2880), "purus.mauris@google.ca", true, "MacKenzie Burnett", "Sophia Boyle", false, null, "PURUS.MAURIS@GOOGLE.CA", "IRIS", "AQAAAAIAAYagAAAAEFHZIvCSf1plsn3QsHjKiK3RTaQ01Gyr+H5fOJiOXQKDprPvdWT0J59GMcQbKbnjfw==", null, true, null, "c6712a25-c14e-4978-86ab-9f4185518ddc", false, new DateTime(2024, 2, 24, 17, 5, 26, 527, DateTimeKind.Utc).AddTicks(2880), "Iris" },
                    { new Guid("d136aab8-52d9-457f-8481-642016d2b35b"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 653, DateTimeKind.Utc).AddTicks(8170), "et.netus.et@outlook.edu", true, "Ralph Valdez", "Beverly Contreras", false, null, "ET.NETUS.ET@OUTLOOK.EDU", "VLADIMIR", "AQAAAAIAAYagAAAAEJxdwHtOaXpHX6KHzv9l+wT5zUhWedXNnO8Rx+2wDPDXVHendJWK5c2WOC4aPy4qWw==", null, true, null, "0f416299-1a15-4bc1-9f6a-8262a61999e4", false, new DateTime(2024, 2, 24, 17, 5, 26, 653, DateTimeKind.Utc).AddTicks(8170), "Vladimir" },
                    { new Guid("d6f47b21-0b09-4413-9d34-344f9cb2539e"), 0, null, new DateTime(2024, 2, 24, 17, 5, 27, 118, DateTimeKind.Utc).AddTicks(3600), "urna@outlook.net", true, "Nyssa Forbes", "Margaret Berg", false, null, "URNA@OUTLOOK.NET", "HAYES", "AQAAAAIAAYagAAAAEE7IDFZLvDqLCpsarNXMm8k4WK5OVdLmwKYqVjcNAJuUCASUCH5lDw9kf6D8OBG7wA==", null, true, null, "9fe55e03-e5a4-45d9-8a21-cb22f7197eb3", false, new DateTime(2024, 2, 24, 17, 5, 27, 118, DateTimeKind.Utc).AddTicks(3600), "Hayes" },
                    { new Guid("ea89b3a0-ff62-4425-bbef-a820fa67bb3e"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 822, DateTimeKind.Utc).AddTicks(2810), "metus.in@protonmail.edu", true, "Cooper Briggs", "Anastasia Heath", false, null, "METUS.IN@PROTONMAIL.EDU", "KAYE", "AQAAAAIAAYagAAAAEGFNu3vm+kg4LeAxstb3fA+1exjakclR87Fa9ZpMLW+I+gG7jj9b5kj2vQE7kY9x1g==", null, true, null, "01f6d404-b13c-4385-ab47-d328dd12a8e3", false, new DateTime(2024, 2, 24, 17, 5, 26, 822, DateTimeKind.Utc).AddTicks(2810), "Kaye" },
                    { new Guid("f80ff19f-4a2f-4f37-abc6-236b9d096611"), 0, null, new DateTime(2024, 2, 24, 17, 5, 26, 611, DateTimeKind.Utc).AddTicks(3510), "fusce.diam.nunc@yahoo.org", true, "Holmes Burton", "Melissa Burgess", false, null, "FUSCE.DIAM.NUNC@YAHOO.ORG", "FREDERICKA", "AQAAAAIAAYagAAAAEEAUDzCCquXrh6w0eI3X/YF1SSpDobkocrgii4oAOQwlR1QT1fVAwfb4vo6snCOzIQ==", null, true, null, "6b36a00c-5573-494f-8278-17a117581fec", false, new DateTime(2024, 2, 24, 17, 5, 26, 611, DateTimeKind.Utc).AddTicks(3510), "Fredericka" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("cae420fb-001a-4df1-9ca0-dbd841ef22ac"), new Guid("5a49c82b-4f25-4e93-84e7-a24df464a72b") },
                    { new Guid("bd7a7276-168d-40c4-88c6-fa809993b6e1"), new Guid("bdbb9a8a-7019-4d8f-bd96-120b6cb6af2c") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_ReceiverUserId",
                table: "Friendships",
                column: "ReceiverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_SenderUserId",
                table: "Friendships",
                column: "SenderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPosts_PostId",
                table: "UserPosts",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPosts_UserId",
                table: "UserPosts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Friendships");

            migrationBuilder.DropTable(
                name: "UserPosts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
