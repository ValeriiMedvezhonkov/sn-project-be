using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sn_project_be.Migrations
{
    /// <inheritdoc />
    public partial class Posts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0dc936eb-4177-415d-ae48-4b83133df596"), new Guid("5232a7fa-b52f-4d39-b703-41f4f0bf046f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0644dff7-fd36-4570-850b-3243fda40864"), new Guid("f8c61f1f-c22e-40f4-9f59-9a3954f86ff6") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0649c594-7674-46f5-8e5c-7c2901f14a3b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2b252b38-9b5f-4ad1-9072-03fd9557a97e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38056a1f-ae9c-4064-9e23-5e61fdef6aa6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("42aaeaeb-6a22-425c-82c6-02fff5cc24ad"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("431776d1-3b94-471d-8043-8dbfac6cce38"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5bc0bade-91c4-42b3-9e79-69176145d2d9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("61671ed0-02c0-436f-bbb8-e4ac7a40874a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("64f2b1d7-7771-4b36-82ba-f85a9abea4b0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("71009e57-f62d-426d-8daf-398f7f643188"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("71b0267f-eaff-4591-815c-1bca2bd47c53"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("948fe301-1297-48a4-b92a-11b47ad100d9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("adadaba8-8941-4e0e-ada0-67b582eafd20"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b800c205-d16b-451e-81ff-c365d90aa678"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba0b0267-9a1a-4f81-8ad6-8559d2e1a459"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be965456-788f-4f4d-9025-916dfa5e2aa9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d3e43058-4bda-4dd2-beb8-402b5e478885"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f6422e-58b8-46ea-be7b-461db3a2b1d5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0f5ecd6-eba0-42f8-bc14-948c6b026bd0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f69df457-8f18-4d15-aa2f-65c71d480286"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f7975ed3-d1f7-442a-9149-2413f7e37ded"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0644dff7-fd36-4570-850b-3243fda40864"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0dc936eb-4177-415d-ae48-4b83133df596"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5232a7fa-b52f-4d39-b703-41f4f0bf046f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8c61f1f-c22e-40f4-9f59-9a3954f86ff6"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("092da31d-f2f8-4c73-af24-a995ec9c8a7b"), null, "User", "USER" },
                    { new Guid("539cef60-64ce-491c-a180-d2491d63d7c2"), null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicUrl", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("0c2b9dd4-ccee-44e0-9cbf-e1995afb9637"), 0, null, new DateTime(2024, 2, 27, 14, 2, 44, 806, DateTimeKind.Utc).AddTicks(9874), "admin285@gmail.com", true, "Admin", "Admin", false, null, "ADMIN285@GMAIL.COM", "AKIHITOADMIN", "AQAAAAIAAYagAAAAEIJvlUdk9Xw8zpU8V2i9GdQMZ2lNc3hjMmCJFvfelnZbEVmynJBg88eG6RBoVZwfpQ==", null, true, null, "21dbd882-eb87-402e-9562-f5d6e4c600bf", false, new DateTime(2024, 2, 27, 14, 2, 44, 806, DateTimeKind.Utc).AddTicks(9877), "AkihitoAdmin" },
                    { new Guid("2451f7b3-c79d-44d3-95ca-01459d03511a"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 200, DateTimeKind.Utc).AddTicks(958), "blandit.congue@protonmail.ca", true, "Ursa", "Pickett", false, null, "BLANDIT.CONGUE@PROTONMAIL.CA", "AMENA", "AQAAAAIAAYagAAAAEEPQhVcGkLDElU1+v8CKL2GxawtF8uTYfAy2JBzNCNgMWQ3vJQam1BMOHOiGcC3UNQ==", null, true, null, "03893ce2-2178-47cb-a934-769b8a036db5", false, new DateTime(2024, 2, 27, 14, 2, 45, 200, DateTimeKind.Utc).AddTicks(959), "Amena" },
                    { new Guid("281ce51e-6128-45a0-b79a-575af2b69569"), 0, null, new DateTime(2024, 2, 27, 14, 2, 44, 873, DateTimeKind.Utc).AddTicks(4652), "porttitor.scelerisque.neque@google.org", true, "Yuli", "Hinton", false, null, "PORTTITOR.SCELERISQUE.NEQUE@GOOGLE.ORG", "GANNON", "AQAAAAIAAYagAAAAEIHQpMjQ3npLw/HsdQ0wynsNwJbvhsK2XZusYar0Uhon+HoyzSIcl68bGXPwPogpig==", null, true, null, "a2fa7f77-c138-4a3f-a0da-04997f6bbe66", false, new DateTime(2024, 2, 27, 14, 2, 44, 873, DateTimeKind.Utc).AddTicks(4652), "Gannon" },
                    { new Guid("33f604eb-dec0-478e-8dbf-dc7614f1d632"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 233, DateTimeKind.Utc).AddTicks(5328), "non.vestibulum@outlook.ca", true, "Amity", "Hess", false, null, "NON.VESTIBULUM@OUTLOOK.CA", "DEBRA", "AQAAAAIAAYagAAAAEKOY5PD2sNXSlJ8kIMRj2XrYIhbjl1SZAz2B8d0JRAGX3BxmrSK6gcMfgDPDhDKsVQ==", null, true, null, "2402eca5-1dc3-475d-b083-5cde7776e841", false, new DateTime(2024, 2, 27, 14, 2, 45, 233, DateTimeKind.Utc).AddTicks(5332), "Debra" },
                    { new Guid("35e675ee-0a72-4021-9a2e-d0c7cb212e22"), 0, null, new DateTime(2024, 2, 27, 14, 2, 44, 973, DateTimeKind.Utc).AddTicks(6471), "risus.in@icloud.net", true, "George", "Weber", false, null, "RISUS.IN@ICLOUD.NET", "HU", "AQAAAAIAAYagAAAAEPhjQvW2GirLWDEsffB2wHlIPaa+JkjlMK7EY8XnLf2SEoQ/KDzDfNhTzhnTB++PvA==", null, true, null, "633a8b88-6ecb-4bc8-9a0a-3930d25aed8f", false, new DateTime(2024, 2, 27, 14, 2, 44, 973, DateTimeKind.Utc).AddTicks(6473), "Hu" },
                    { new Guid("3a43f1cd-182b-4663-852c-5ffc402abd8c"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 533, DateTimeKind.Utc).AddTicks(9574), "amet.risus.donec@hotmail.ca", true, "Jelani", "Conrad", false, null, "AMET.RISUS.DONEC@HOTMAIL.CA", "KAY", "AQAAAAIAAYagAAAAEM5eRX+3iZkQjXcvzOHVyxmMUPG/w0eg59ta78T+qC9zMnl15SFZxEinWYNJV4vLTg==", null, true, null, "102dcc77-02ec-4a43-9e69-8da3d8922c4a", false, new DateTime(2024, 2, 27, 14, 2, 45, 533, DateTimeKind.Utc).AddTicks(9576), "Kay" },
                    { new Guid("50debb43-f3f9-48e6-af21-7510aef1c997"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 267, DateTimeKind.Utc).AddTicks(3246), "metus.in@protonmail.edu", true, "Cooper", "Briggs", false, null, "METUS.IN@PROTONMAIL.EDU", "KAYE", "AQAAAAIAAYagAAAAEChv20T3gMpaTJcWLVQk+tHTAA+oqE+5dX5gePJ4y41Cc3owEBSUxRj0OHeCH89+bg==", null, true, null, "4bb0fa48-d558-4cd8-9807-4f8a3c1d0cd2", false, new DateTime(2024, 2, 27, 14, 2, 45, 267, DateTimeKind.Utc).AddTicks(3248), "Kaye" },
                    { new Guid("562e4fa7-d52a-4f23-abb8-283006e94c00"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 100, DateTimeKind.Utc).AddTicks(3356), "fusce.diam.nunc@yahoo.org", true, "Holmes", "Burton", false, null, "FUSCE.DIAM.NUNC@YAHOO.ORG", "FREDERICKA", "AQAAAAIAAYagAAAAEB3v57T9874Jx2Nau5i2OblbOlIr5vTuYYpZa4eFm7E/lv63z5RO0cV7u52gYKPZFg==", null, true, null, "49ce61d1-53e8-4ec2-8960-eb1325a34bb3", false, new DateTime(2024, 2, 27, 14, 2, 45, 100, DateTimeKind.Utc).AddTicks(3358), "Fredericka" },
                    { new Guid("59a4ea67-b5cd-4976-9991-9552ed728ad0"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 166, DateTimeKind.Utc).AddTicks(9782), "ipsum.curabitur@outlook.com", true, "Victoria", "Weaver", false, null, "IPSUM.CURABITUR@OUTLOOK.COM", "CAILIN", "AQAAAAIAAYagAAAAEKsO2Tz1qoDW7wx9JY/ok2lThzUrFuo8hv5T+khM/aPo8NJyUVo4rQ9ta0ZO081Y9g==", null, true, null, "f3da7176-39cc-457b-bde8-6ef865091088", false, new DateTime(2024, 2, 27, 14, 2, 45, 166, DateTimeKind.Utc).AddTicks(9784), "Cailin" },
                    { new Guid("69897cba-b7da-4431-97b9-dd13a04969d1"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 6, DateTimeKind.Utc).AddTicks(6752), "purus.mauris@google.ca", true, "MacKenzie", "Burnett", false, null, "PURUS.MAURIS@GOOGLE.CA", "IRIS", "AQAAAAIAAYagAAAAENijOwrYHgYB7+faLfBq8YJrL/t8ZK7xybx/sMglO3qzUxSjULr/tWLL5d6+nBbVtg==", null, true, null, "ecb268cb-b27f-467e-8d48-3d3898bfbac1", false, new DateTime(2024, 2, 27, 14, 2, 45, 6, DateTimeKind.Utc).AddTicks(6753), "Iris" },
                    { new Guid("82b8cd4c-62fb-44dd-bf0a-1b16b02af0f5"), 0, null, new DateTime(2024, 2, 27, 14, 2, 44, 940, DateTimeKind.Utc).AddTicks(1348), "pede.nec@outlook.com", true, "Bianca", "Baxter", false, null, "PEDE.NEC@OUTLOOK.COM", "BO", "AQAAAAIAAYagAAAAEC+YkiBWdMAibUSgWOpMry7ooxtG2OoBnOGdQbg3RJIfuZr4z9ycTAYQ8jk+zyVc5w==", null, true, null, "5074ec74-9b52-43fe-a017-fa9e8d19f213", false, new DateTime(2024, 2, 27, 14, 2, 44, 940, DateTimeKind.Utc).AddTicks(1350), "Bo" },
                    { new Guid("8e7d98f8-bf2d-4cbb-93f9-bc2bc846007d"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 300, DateTimeKind.Utc).AddTicks(5739), "quisque@hotmail.edu", true, "Brynne", "Johnson", false, null, "QUISQUE@HOTMAIL.EDU", "TIMON", "AQAAAAIAAYagAAAAEECLb3OwYt9CxlPywq3h+pkCoAo2+eCA6x9gDbUEIcD10mhHShSUHjPySY18o8LLWA==", null, true, null, "6f1c97af-6905-4246-8802-b97631c2ffd1", false, new DateTime(2024, 2, 27, 14, 2, 45, 300, DateTimeKind.Utc).AddTicks(5741), "Timon" },
                    { new Guid("9241c1d5-4aae-4122-8c19-ce9404517431"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 55, DateTimeKind.Utc).AddTicks(1617), "vitae@yahoo.net", true, "Kiara", "Perez", false, null, "VITAE@YAHOO.NET", "MAGGIE", "AQAAAAIAAYagAAAAEPsqqRpyDJdNSwnbk0G5KIcZuA3JWEIiEHNa4JXL7rjwVeD4kdO8YWZCHYk7exVrBA==", null, true, null, "53d970ad-b0f6-4c65-a612-d8c092be5628", false, new DateTime(2024, 2, 27, 14, 2, 45, 55, DateTimeKind.Utc).AddTicks(1623), "Maggie" },
                    { new Guid("96ec9928-e9e2-49dd-97d9-d514d0a078bc"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 433, DateTimeKind.Utc).AddTicks(6982), "turpis.in.condimentum@icloud.edu", true, "Melissa", "Rosa", false, null, "TURPIS.IN.CONDIMENTUM@ICLOUD.EDU", "UNITY", "AQAAAAIAAYagAAAAEFsJz0gAhRQ+cBw4OKSanrLOB6rlZgjri13REfOhtbL5RoGhL6OuM5/BVdprE/76+w==", null, true, null, "945938e7-5fa4-48ab-bd75-aab63b88278f", false, new DateTime(2024, 2, 27, 14, 2, 45, 433, DateTimeKind.Utc).AddTicks(6983), "Unity" },
                    { new Guid("9aa170fb-cd47-4394-9ef3-cd55940abc9a"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 366, DateTimeKind.Utc).AddTicks(9991), "integer.vulputate@yahoo.com", true, "Brandon", "Waller", false, null, "INTEGER.VULPUTATE@YAHOO.COM", "PHILLIP", "AQAAAAIAAYagAAAAEN/PSIRBhILsL/bqNSmZV3KzRVp6z+Jw87h5Asoy7aulnh538N+oISO87WbVIlnCcw==", null, true, null, "ca6487dc-1d2f-4024-a7b4-9f30e2b41383", false, new DateTime(2024, 2, 27, 14, 2, 45, 366, DateTimeKind.Utc).AddTicks(9993), "Phillip" },
                    { new Guid("aad20e5d-98f2-4959-ae7c-701247eeee53"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 400, DateTimeKind.Utc).AddTicks(619), "sed.nec@hotmail.org", true, "Gage", "Goodman", false, null, "SED.NEC@HOTMAIL.ORG", "LEAH", "AQAAAAIAAYagAAAAEMVCHby+PniBZOcURjwmDnF2sdSwopptqhTwh9ooPE7JO+HbNBVGzwK5At5sdIXnaQ==", null, true, null, "dfe34eb5-07d1-478f-bfb7-8f921329be99", false, new DateTime(2024, 2, 27, 14, 2, 45, 400, DateTimeKind.Utc).AddTicks(619), "Leah" },
                    { new Guid("b4455321-6e16-4011-bca2-670c1a7db1b8"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 500, DateTimeKind.Utc).AddTicks(2326), "urna@outlook.net", true, "Nyssa", "Forbes", false, null, "URNA@OUTLOOK.NET", "HAYES", "AQAAAAIAAYagAAAAENxzXT/H/czFYYaB8Nas7bl9QL4dhpgDa8IN73Z+Yt7/wc0C1s/b5jkQ1jXPeHSglQ==", null, true, null, "aa7485a4-7afe-467a-9f9d-7b63d931ac83", false, new DateTime(2024, 2, 27, 14, 2, 45, 500, DateTimeKind.Utc).AddTicks(2326), "Hayes" },
                    { new Guid("bd977635-cff5-4c59-858a-77454405222d"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 133, DateTimeKind.Utc).AddTicks(6750), "et.netus.et@outlook.edu", true, "Ralph", "Valdez", false, null, "ET.NETUS.ET@OUTLOOK.EDU", "VLADIMIR", "AQAAAAIAAYagAAAAENKpxj2wQWAkMkp1+R1G84HlCvXTgIwWZ2OZW1tCl2aDeNvomRSyp00C3bwYSzjOUw==", null, true, null, "40e322b9-9928-41b4-bdf2-e8425cab7f9d", false, new DateTime(2024, 2, 27, 14, 2, 45, 133, DateTimeKind.Utc).AddTicks(6752), "Vladimir" },
                    { new Guid("dc03d5cb-0633-452a-85b4-8b206443f5a2"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 467, DateTimeKind.Utc).AddTicks(1190), "suscipit.nonummy@yahoo.couk", true, "Serina", "Sparks", false, null, "SUSCIPIT.NONUMMY@YAHOO.COUK", "ABBOT", "AQAAAAIAAYagAAAAEEdThkiADYh/ylvuDRwUhYUy7OJUJJ3BCdRIESIw3H3NQ7gQWcJaTi4rLglfQJDZLQ==", null, true, null, "5d960b45-55bd-4c9a-b532-2557de35557f", false, new DateTime(2024, 2, 27, 14, 2, 45, 467, DateTimeKind.Utc).AddTicks(1190), "Abbot" },
                    { new Guid("e3643ac1-9b36-401c-a5f3-7ebe35e00a1a"), 0, null, new DateTime(2024, 2, 27, 14, 2, 45, 333, DateTimeKind.Utc).AddTicks(8630), "sed.molestie@icloud.couk", true, "Bruno", "Hurst", false, null, "SED.MOLESTIE@ICLOUD.COUK", "BERT", "AQAAAAIAAYagAAAAEF44zoLlg49xOSxRdimkXgxKEUwFtH7TEJ3RF0kCpEG0ZtYWIaKqBqI0XXQP+kBxkw==", null, true, null, "968697de-4658-42d4-ad9b-1f1ebe92b8bb", false, new DateTime(2024, 2, 27, 14, 2, 45, 333, DateTimeKind.Utc).AddTicks(8631), "Bert" },
                    { new Guid("f26f452c-eda5-4db2-b956-77220183101a"), 0, null, new DateTime(2024, 2, 27, 14, 2, 44, 906, DateTimeKind.Utc).AddTicks(7645), "ut.odio@yahoo.couk", true, "Maisie", "Lawrence", false, null, "UT.ODIO@YAHOO.COUK", "ARDEN", "AQAAAAIAAYagAAAAEJxwRongSi4MV5MTUUqkKAezEZbp64XOHUxoEw1jZ5wx76CgqkZdIuZI+7bn4AOqyg==", null, true, null, "04e59f43-e07e-4515-a5cd-1fcae347bf80", false, new DateTime(2024, 2, 27, 14, 2, 44, 906, DateTimeKind.Utc).AddTicks(7647), "Arden" },
                    { new Guid("ff68914d-4983-4150-ba9a-ec949f7ffd00"), 0, null, new DateTime(2024, 2, 27, 14, 2, 44, 840, DateTimeKind.Utc).AddTicks(1331), "medvezhonkov285@gmail.com", true, "Valerii", "Medvezhonkov", false, null, "MEDVEZHONKOV285@GMAIL.COM", "AKIHITO", "AQAAAAIAAYagAAAAELwniNZuZa2eODmRF26FtbehIyEXN7BuUPUCKaswlc31G/sJD4ZSt1BLNdg7J04t1Q==", null, true, null, "aeaf81d8-1718-49f5-8ead-1416ebe88843", false, new DateTime(2024, 2, 27, 14, 2, 44, 840, DateTimeKind.Utc).AddTicks(1332), "Akihito" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0daf7c70-c2a0-4020-a885-8f21293dc9de"), "arcu. Morbi sit amet massa. Quisque porttitor eros nec tellus. Nunc lectus pede, ultrices a, auctor non, feugiat nec, diam. Duis", new DateTime(2023, 8, 18, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9354), "diam. Pellentesque", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9355) },
                    { new Guid("16e87c29-c0c3-4fc3-b71a-d4eacdaa4aa9"), "Mauris quis turpis vitae purus gravida sagittis. Duis gravida. Praesent eu nulla at sem molestie sodales. Mauris blandit enim consequat purus. Maecenas libero est, congue a, aliquet vel, vulputate eu, odio. Phasellus at augue id ante dictum cursus. Nunc", new DateTime(2023, 10, 29, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9346), "nulla. Integer urna. Vivamus molestie dapibus ligula.", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9347) },
                    { new Guid("271f5197-0214-4e51-a5f3-b2d6bd8f2600"), "ipsum. Suspendisse sagittis. Nullam vitae diam. Proin dolor. Nulla semper tellus id nunc interdum feugiat. Sed nec metus facilisis lorem tristique aliquet. Phasellus fermentum convallis ligula.", new DateTime(2023, 3, 12, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9252), "dictum sapien. Aenean massa. Integer", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9253) },
                    { new Guid("31089320-2542-4d14-8e6f-0553cc351597"), "pretium neque. Morbi quis urna.", new DateTime(2023, 8, 28, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9361), "Nulla tincidunt, neque vitae", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9363) },
                    { new Guid("4b067edb-5c51-4a7c-8869-0d2f911f2529"), "mauris ut mi. Duis risus odio, auctor vitae, aliquet nec, imperdiet nec, leo. Morbi neque tellus,", new DateTime(2023, 11, 23, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9349), "at sem molestie sodales. Mauris blandit enim", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9350) },
                    { new Guid("4e4c8967-c8f5-4918-a221-7654785f794b"), "vitae, aliquet nec, imperdiet nec, leo. Morbi neque tellus, imperdiet non, vestibulum nec, euismod in, dolor. Fusce feugiat. Lorem ipsum dolor sit", new DateTime(2023, 12, 26, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9344), "diam at pretium aliquet, metus", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9345) },
                    { new Guid("4ef9cad6-0473-47e1-819d-1b053521741b"), "diam vel arcu. Curabitur ut odio vel est tempor bibendum. Donec felis orci, adipiscing non, luctus sit amet, faucibus ut, nulla. Cras eu tellus eu augue porttitor interdum. Sed auctor odio", new DateTime(2024, 2, 11, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9352), "neque. Morbi quis urna. Nunc quis arcu vel quam", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9352) },
                    { new Guid("50903b48-1e70-4a99-94a5-64cd032c4f45"), "sem. Nulla interdum. Curabitur dictum. Phasellus in felis. Nulla tempor augue ac ipsum. Phasellus vitae mauris sit amet lorem semper auctor. Mauris vel turpis. Aliquam adipiscing", new DateTime(2023, 8, 24, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9270), "arcu. Sed et libero. Proin mi. Aliquam gravida mauris", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9271) },
                    { new Guid("5f31f601-aa2a-4da5-9033-dc622a8fe263"), "at pede. Cras vulputate velit eu sem. Pellentesque ut ipsum ac mi eleifend egestas. Sed pharetra, felis eget varius ultrices, mauris ipsum porta elit, a feugiat tellus lorem eu metus. In lorem. Donec elementum, lorem ut aliquam iaculis, lacus", new DateTime(2024, 2, 23, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9275), "ut, sem. Nulla interdum. Curabitur dictum. Phasellus in", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9276) },
                    { new Guid("79a3d487-8dc1-4934-9af5-4301e0fab079"), "augue. Sed molestie. Sed id risus quis diam luctus lobortis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos hymenaeos. Mauris ut quam vel sapien imperdiet ornare. In faucibus.", new DateTime(2023, 8, 13, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9281), "vestibulum massa rutrum magna. Cras convallis convallis dolor.", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9337) },
                    { new Guid("7fdb775a-f620-4e73-a295-ffc328a59f37"), "et, commodo at, libero. Morbi accumsan laoreet ipsum. Curabitur consequat, lectus sit amet luctus vulputate, nisi sem semper erat, in consectetuer ipsum nunc id enim. Curabitur massa. Vestibulum accumsan neque et nunc.", new DateTime(2023, 3, 11, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9261), "vitae", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9262) },
                    { new Guid("8590ae49-0a94-4d52-8088-b3427c0d8d26"), "vestibulum massa rutrum magna. Cras convallis convallis dolor. Quisque tincidunt pede ac urna. Ut tincidunt vehicula risus. Nulla eget metus eu erat semper rutrum. Fusce dolor quam,", new DateTime(2023, 1, 28, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9359), "ridiculus mus. Proin vel nisl. Quisque fringilla euismod", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9360) },
                    { new Guid("8e1e49db-31d4-440d-a46e-8169302e38d0"), "vehicula risus. Nulla eget metus eu erat semper rutrum. Fusce dolor quam, elementum at, egestas a, scelerisque sed, sapien. Nunc pulvinar arcu et pede. Nunc sed orci lobortis augue scelerisque mollis. Phasellus libero mauris, aliquam eu, accumsan", new DateTime(2023, 2, 3, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9273), "nibh vulputate", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9274) },
                    { new Guid("902fc5ce-9d13-4f8e-8e81-a18c910a803b"), "eu odio tristique pharetra. Quisque ac libero nec ligula consectetuer rhoncus.", new DateTime(2023, 2, 1, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9357), "ridiculus mus. Proin vel", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9358) },
                    { new Guid("b1acd71b-d830-46cb-a5b1-be2968f06244"), "sapien. Aenean massa. Integer vitae nibh. Donec est mauris, rhoncus id, mollis nec,", new DateTime(2023, 6, 22, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9339), "Nullam suscipit, est ac facilisis facilisis, magna tellus faucibus leo,", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9340) },
                    { new Guid("bf110d5b-036b-4e19-aff1-d194c0022fbd"), "id, ante. Nunc mauris sapien, cursus in, hendrerit consectetuer, cursus et, magna. Praesent interdum ligula eu enim. Etiam imperdiet dictum magna. Ut tincidunt orci quis lectus. Nullam suscipit, est ac facilisis facilisis, magna tellus", new DateTime(2023, 8, 25, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9341), "ac mattis", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9343) },
                    { new Guid("c55146c8-8582-42d4-a9a2-b4aa43b15753"), "rutrum eu, ultrices sit amet, risus. Donec nibh enim, gravida sit amet, dapibus id,", new DateTime(2023, 5, 12, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9183), "Integer urna. Vivamus molestie dapibus ligula. Aliquam erat", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9239) },
                    { new Guid("e26d1acf-6614-483a-819a-ec0031ce0b27"), "Quisque nonummy ipsum non arcu. Vivamus sit amet risus. Donec egestas. Aliquam nec enim. Nunc ut", new DateTime(2023, 2, 26, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9255), "tincidunt aliquam arcu. Aliquam", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9256) },
                    { new Guid("f0c7817b-a58a-4cd3-af54-e22b1fc08f4b"), "ac facilisis", new DateTime(2023, 12, 10, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9277), "ac sem ut dolor", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9279) },
                    { new Guid("fc44550a-76ef-4d96-947d-47f70733996a"), "lobortis ultrices. Vivamus rhoncus. Donec est.", new DateTime(2023, 2, 3, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9257), "est, congue a, aliquet", new DateTime(2024, 2, 27, 14, 2, 45, 567, DateTimeKind.Utc).AddTicks(9260) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("539cef60-64ce-491c-a180-d2491d63d7c2"), new Guid("0c2b9dd4-ccee-44e0-9cbf-e1995afb9637") },
                    { new Guid("092da31d-f2f8-4c73-af24-a995ec9c8a7b"), new Guid("ff68914d-4983-4150-ba9a-ec949f7ffd00") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("539cef60-64ce-491c-a180-d2491d63d7c2"), new Guid("0c2b9dd4-ccee-44e0-9cbf-e1995afb9637") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("092da31d-f2f8-4c73-af24-a995ec9c8a7b"), new Guid("ff68914d-4983-4150-ba9a-ec949f7ffd00") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2451f7b3-c79d-44d3-95ca-01459d03511a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("281ce51e-6128-45a0-b79a-575af2b69569"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("33f604eb-dec0-478e-8dbf-dc7614f1d632"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e675ee-0a72-4021-9a2e-d0c7cb212e22"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a43f1cd-182b-4663-852c-5ffc402abd8c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("50debb43-f3f9-48e6-af21-7510aef1c997"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("562e4fa7-d52a-4f23-abb8-283006e94c00"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a4ea67-b5cd-4976-9991-9552ed728ad0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("69897cba-b7da-4431-97b9-dd13a04969d1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("82b8cd4c-62fb-44dd-bf0a-1b16b02af0f5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8e7d98f8-bf2d-4cbb-93f9-bc2bc846007d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9241c1d5-4aae-4122-8c19-ce9404517431"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("96ec9928-e9e2-49dd-97d9-d514d0a078bc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9aa170fb-cd47-4394-9ef3-cd55940abc9a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aad20e5d-98f2-4959-ae7c-701247eeee53"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b4455321-6e16-4011-bca2-670c1a7db1b8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bd977635-cff5-4c59-858a-77454405222d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dc03d5cb-0633-452a-85b4-8b206443f5a2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3643ac1-9b36-401c-a5f3-7ebe35e00a1a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f26f452c-eda5-4db2-b956-77220183101a"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0daf7c70-c2a0-4020-a885-8f21293dc9de"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("16e87c29-c0c3-4fc3-b71a-d4eacdaa4aa9"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("271f5197-0214-4e51-a5f3-b2d6bd8f2600"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("31089320-2542-4d14-8e6f-0553cc351597"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("4b067edb-5c51-4a7c-8869-0d2f911f2529"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("4e4c8967-c8f5-4918-a221-7654785f794b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("4ef9cad6-0473-47e1-819d-1b053521741b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("50903b48-1e70-4a99-94a5-64cd032c4f45"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("5f31f601-aa2a-4da5-9033-dc622a8fe263"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("79a3d487-8dc1-4934-9af5-4301e0fab079"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("7fdb775a-f620-4e73-a295-ffc328a59f37"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("8590ae49-0a94-4d52-8088-b3427c0d8d26"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("8e1e49db-31d4-440d-a46e-8169302e38d0"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("902fc5ce-9d13-4f8e-8e81-a18c910a803b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b1acd71b-d830-46cb-a5b1-be2968f06244"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("bf110d5b-036b-4e19-aff1-d194c0022fbd"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("c55146c8-8582-42d4-a9a2-b4aa43b15753"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("e26d1acf-6614-483a-819a-ec0031ce0b27"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f0c7817b-a58a-4cd3-af54-e22b1fc08f4b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("fc44550a-76ef-4d96-947d-47f70733996a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("092da31d-f2f8-4c73-af24-a995ec9c8a7b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("539cef60-64ce-491c-a180-d2491d63d7c2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0c2b9dd4-ccee-44e0-9cbf-e1995afb9637"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff68914d-4983-4150-ba9a-ec949f7ffd00"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0644dff7-fd36-4570-850b-3243fda40864"), null, "Administrator", "ADMINISTRATOR" },
                    { new Guid("0dc936eb-4177-415d-ae48-4b83133df596"), null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicUrl", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("0649c594-7674-46f5-8e5c-7c2901f14a3b"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 182, DateTimeKind.Utc).AddTicks(679), "metus.in@protonmail.edu", true, "Cooper", "Briggs", false, null, "METUS.IN@PROTONMAIL.EDU", "KAYE", "AQAAAAIAAYagAAAAEIL7cVQHReo8YW7tYHdsHbGg8cfW26z9wKVo65e1nl713Yb5mr4seS/0IRSFq4CEyA==", null, true, null, "dd0bf2c0-3d8a-4d30-b536-efd73d54139b", false, new DateTime(2024, 2, 25, 18, 10, 10, 182, DateTimeKind.Utc).AddTicks(681), "Kaye" },
                    { new Guid("2b252b38-9b5f-4ad1-9072-03fd9557a97e"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 349, DateTimeKind.Utc).AddTicks(1468), "turpis.in.condimentum@icloud.edu", true, "Melissa", "Rosa", false, null, "TURPIS.IN.CONDIMENTUM@ICLOUD.EDU", "UNITY", "AQAAAAIAAYagAAAAEL6RQJLJ6mFCwMlVIVjDXL5+0EXSvyssjK4xdxg8hcc9/RmRkEQ3OLf6rWUkmp8WpQ==", null, true, null, "6c3009ec-fc72-4ac7-9cf0-d947fd626178", false, new DateTime(2024, 2, 25, 18, 10, 10, 349, DateTimeKind.Utc).AddTicks(1470), "Unity" },
                    { new Guid("38056a1f-ae9c-4064-9e23-5e61fdef6aa6"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 415, DateTimeKind.Utc).AddTicks(7636), "urna@outlook.net", true, "Nyssa", "Forbes", false, null, "URNA@OUTLOOK.NET", "HAYES", "AQAAAAIAAYagAAAAEKPnr332FdN8A68UV7a5VWKQg/54UbKllU90jQzu1QvKnJXXnKfW0ktSvpoHBZa2Ng==", null, true, null, "671ea42f-1522-4bac-9894-e1b6c3d1c611", false, new DateTime(2024, 2, 25, 18, 10, 10, 415, DateTimeKind.Utc).AddTicks(7639), "Hayes" },
                    { new Guid("42aaeaeb-6a22-425c-82c6-02fff5cc24ad"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 281, DateTimeKind.Utc).AddTicks(9886), "integer.vulputate@yahoo.com", true, "Brandon", "Waller", false, null, "INTEGER.VULPUTATE@YAHOO.COM", "PHILLIP", "AQAAAAIAAYagAAAAEHVrNCDzc7IQtpY7uHgP7YvELM1JA1h5/+uKnsRRS5L5rAN6ympRa5mnzqjSDwAAZA==", null, true, null, "c7e730aa-f2a7-4776-b152-9103e77ddc4d", false, new DateTime(2024, 2, 25, 18, 10, 10, 281, DateTimeKind.Utc).AddTicks(9888), "Phillip" },
                    { new Guid("431776d1-3b94-471d-8043-8dbfac6cce38"), 0, null, new DateTime(2024, 2, 25, 18, 10, 9, 944, DateTimeKind.Utc).AddTicks(6044), "purus.mauris@google.ca", true, "MacKenzie", "Burnett", false, null, "PURUS.MAURIS@GOOGLE.CA", "IRIS", "AQAAAAIAAYagAAAAEPPMyVNYNqnTN2FIUX7rNOMd6BntyCi3C7gQYkzc+ARDuwbypFUaGrZ0fq7wis6AYA==", null, true, null, "38b174c9-ed3f-45e7-b6a9-e755c73fcd56", false, new DateTime(2024, 2, 25, 18, 10, 9, 944, DateTimeKind.Utc).AddTicks(6048), "Iris" },
                    { new Guid("5232a7fa-b52f-4d39-b703-41f4f0bf046f"), 0, null, new DateTime(2024, 2, 25, 18, 10, 9, 778, DateTimeKind.Utc).AddTicks(648), "medvezhonkov285@gmail.com", true, "Valerii", "Medvezhonkov", false, null, "MEDVEZHONKOV285@GMAIL.COM", "AKIHITO", "AQAAAAIAAYagAAAAEJycT4z5YuhEwUyzomrflGn/9/jI4m0mXuqObeoNa5o/Z+YFKhcJgtW3XEy+D+GETw==", null, true, null, "875ef712-d84d-4fea-85f9-9fac5f2efc66", false, new DateTime(2024, 2, 25, 18, 10, 9, 778, DateTimeKind.Utc).AddTicks(650), "Akihito" },
                    { new Guid("5bc0bade-91c4-42b3-9e79-69176145d2d9"), 0, null, new DateTime(2024, 2, 25, 18, 10, 9, 811, DateTimeKind.Utc).AddTicks(2002), "porttitor.scelerisque.neque@google.org", true, "Yuli", "Hinton", false, null, "PORTTITOR.SCELERISQUE.NEQUE@GOOGLE.ORG", "GANNON", "AQAAAAIAAYagAAAAEDgTEFo7AJDovJy/g5o3Vh4tlsaZcLVgXYpQHfsyEDDcnDQARMiNwLFyefdzH2PILA==", null, true, null, "1266d885-e724-4253-9185-6a52c4476c9d", false, new DateTime(2024, 2, 25, 18, 10, 9, 811, DateTimeKind.Utc).AddTicks(2004), "Gannon" },
                    { new Guid("61671ed0-02c0-436f-bbb8-e4ac7a40874a"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 448, DateTimeKind.Utc).AddTicks(7961), "amet.risus.donec@hotmail.ca", true, "Jelani", "Conrad", false, null, "AMET.RISUS.DONEC@HOTMAIL.CA", "KAY", "AQAAAAIAAYagAAAAEJjnDI/wZzmHerxz1fJuMEufK6J2H9sJYSmEbXBp/BLVk4mLOKfBvZ7OwIgXm22T3Q==", null, true, null, "5ac98a1f-3a5e-4aa5-8c4c-05dc9b573c14", false, new DateTime(2024, 2, 25, 18, 10, 10, 448, DateTimeKind.Utc).AddTicks(7963), "Kay" },
                    { new Guid("64f2b1d7-7771-4b36-82ba-f85a9abea4b0"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 248, DateTimeKind.Utc).AddTicks(9691), "sed.molestie@icloud.couk", true, "Bruno", "Hurst", false, null, "SED.MOLESTIE@ICLOUD.COUK", "BERT", "AQAAAAIAAYagAAAAEPD5l4uB//GT0G7jMDdOeGfjfNRfYtTbtVpWIuNUY4mfKF/LVwxgP5BesnJbR/AJmQ==", null, true, null, "8d8de1f8-8fb5-4a74-bcb2-38fb72703e36", false, new DateTime(2024, 2, 25, 18, 10, 10, 248, DateTimeKind.Utc).AddTicks(9694), "Bert" },
                    { new Guid("71009e57-f62d-426d-8daf-398f7f643188"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 11, DateTimeKind.Utc).AddTicks(2737), "fusce.diam.nunc@yahoo.org", true, "Holmes", "Burton", false, null, "FUSCE.DIAM.NUNC@YAHOO.ORG", "FREDERICKA", "AQAAAAIAAYagAAAAEEWsS9tZ0oNlJpBkMhMotS825NxOurutcR0rBMsOs4GyH14r5JiajcErGwZ85d3GqA==", null, true, null, "5ce83d11-bd21-4835-b610-f41d5bf3caf5", false, new DateTime(2024, 2, 25, 18, 10, 10, 11, DateTimeKind.Utc).AddTicks(2739), "Fredericka" },
                    { new Guid("71b0267f-eaff-4591-815c-1bca2bd47c53"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 148, DateTimeKind.Utc).AddTicks(8069), "non.vestibulum@outlook.ca", true, "Amity", "Hess", false, null, "NON.VESTIBULUM@OUTLOOK.CA", "DEBRA", "AQAAAAIAAYagAAAAEBif1IuJ+c92cLZLaY8VvYSH8o3Sy4VJXbLzGXZ4+SIgwxpYkqHWKaICekP5zfK25w==", null, true, null, "b6e0471c-54b5-4f4b-8d15-e4944f8ba118", false, new DateTime(2024, 2, 25, 18, 10, 10, 148, DateTimeKind.Utc).AddTicks(8072), "Debra" },
                    { new Guid("948fe301-1297-48a4-b92a-11b47ad100d9"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 115, DateTimeKind.Utc).AddTicks(5026), "blandit.congue@protonmail.ca", true, "Ursa", "Pickett", false, null, "BLANDIT.CONGUE@PROTONMAIL.CA", "AMENA", "AQAAAAIAAYagAAAAEHG6rbprM/qPTQ5Td+W/ZMt/VK8641+FOKDUx7ID3+RE5/mydGlmZuusmURUzBEcLQ==", null, true, null, "c8d1a285-8e0c-4108-9e0a-c8ad28bb3cd7", false, new DateTime(2024, 2, 25, 18, 10, 10, 115, DateTimeKind.Utc).AddTicks(5029), "Amena" },
                    { new Guid("adadaba8-8941-4e0e-ada0-67b582eafd20"), 0, null, new DateTime(2024, 2, 25, 18, 10, 9, 877, DateTimeKind.Utc).AddTicks(6621), "pede.nec@outlook.com", true, "Bianca", "Baxter", false, null, "PEDE.NEC@OUTLOOK.COM", "BO", "AQAAAAIAAYagAAAAEO6NrFl4jljFePaFudg/F9yM8kHjBfGShOtvLtMju2LR44BDBHYczsXiTjXQcAP4Rg==", null, true, null, "2ce3710c-82f1-4959-b0f3-784779057e18", false, new DateTime(2024, 2, 25, 18, 10, 9, 877, DateTimeKind.Utc).AddTicks(6623), "Bo" },
                    { new Guid("b800c205-d16b-451e-81ff-c365d90aa678"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 81, DateTimeKind.Utc).AddTicks(8924), "ipsum.curabitur@outlook.com", true, "Victoria", "Weaver", false, null, "IPSUM.CURABITUR@OUTLOOK.COM", "CAILIN", "AQAAAAIAAYagAAAAEMCLGc4tACRp40ExObAZQRx88Bd4j925jApQsiZ/HMuWXKC/CyYXnhAxlFsOwOYtoQ==", null, true, null, "9362af28-e620-4600-9149-81164cb23ea3", false, new DateTime(2024, 2, 25, 18, 10, 10, 81, DateTimeKind.Utc).AddTicks(8927), "Cailin" },
                    { new Guid("ba0b0267-9a1a-4f81-8ad6-8559d2e1a459"), 0, null, new DateTime(2024, 2, 25, 18, 10, 9, 977, DateTimeKind.Utc).AddTicks(9857), "vitae@yahoo.net", true, "Kiara", "Perez", false, null, "VITAE@YAHOO.NET", "MAGGIE", "AQAAAAIAAYagAAAAEMtoxSEybUo0g6lp1YxfE8OSdV2reviFA1T8pUoKXIMC2tFcFFJzW3xwDvoYg2KMWw==", null, true, null, "002d2bdf-98f8-4f16-ae19-1ed21e76ad1b", false, new DateTime(2024, 2, 25, 18, 10, 9, 977, DateTimeKind.Utc).AddTicks(9860), "Maggie" },
                    { new Guid("be965456-788f-4f4d-9025-916dfa5e2aa9"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 315, DateTimeKind.Utc).AddTicks(423), "sed.nec@hotmail.org", true, "Gage", "Goodman", false, null, "SED.NEC@HOTMAIL.ORG", "LEAH", "AQAAAAIAAYagAAAAENz/NX7ncYWViNkRulzgeEJM7pV+jWPT2DFEZE63uz/ehspo3TE5r5q5C3MC2ZxQmQ==", null, true, null, "fad64f0d-389d-4ca3-90fc-e7bd7ef7ebfa", false, new DateTime(2024, 2, 25, 18, 10, 10, 315, DateTimeKind.Utc).AddTicks(425), "Leah" },
                    { new Guid("d3e43058-4bda-4dd2-beb8-402b5e478885"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 215, DateTimeKind.Utc).AddTicks(7896), "quisque@hotmail.edu", true, "Brynne", "Johnson", false, null, "QUISQUE@HOTMAIL.EDU", "TIMON", "AQAAAAIAAYagAAAAEB6PJbCFCc0oTCHhAtxi8v2kloT3Ihv9M1azaUY5yiFoEBflnOHFzwjjwqbTowYjGA==", null, true, null, "236de044-644e-48aa-8d26-62b68e66a8f3", false, new DateTime(2024, 2, 25, 18, 10, 10, 215, DateTimeKind.Utc).AddTicks(7900), "Timon" },
                    { new Guid("d9f6422e-58b8-46ea-be7b-461db3a2b1d5"), 0, null, new DateTime(2024, 2, 25, 18, 10, 9, 844, DateTimeKind.Utc).AddTicks(5774), "ut.odio@yahoo.couk", true, "Maisie", "Lawrence", false, null, "UT.ODIO@YAHOO.COUK", "ARDEN", "AQAAAAIAAYagAAAAEPnhEpy4zhytljJ/QniaLnLg2SgR9BEDfXHduUEzpmWai6RNclxdiCzU7u5AU+XObw==", null, true, null, "c9aa99b1-3aad-4a1e-8345-cd8e5c3d9a34", false, new DateTime(2024, 2, 25, 18, 10, 9, 844, DateTimeKind.Utc).AddTicks(5777), "Arden" },
                    { new Guid("e0f5ecd6-eba0-42f8-bc14-948c6b026bd0"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 382, DateTimeKind.Utc).AddTicks(2335), "suscipit.nonummy@yahoo.couk", true, "Serina", "Sparks", false, null, "SUSCIPIT.NONUMMY@YAHOO.COUK", "ABBOT", "AQAAAAIAAYagAAAAEFUGmSXTkNfb4zdHWjGZ2lKe4EYWTsUQvfoEn3ky64gU6OC10D+8nPKlN7xrXMpf7Q==", null, true, null, "99655a56-4d83-49e4-a51a-caed4adaba3d", false, new DateTime(2024, 2, 25, 18, 10, 10, 382, DateTimeKind.Utc).AddTicks(2335), "Abbot" },
                    { new Guid("f69df457-8f18-4d15-aa2f-65c71d480286"), 0, null, new DateTime(2024, 2, 25, 18, 10, 10, 45, DateTimeKind.Utc).AddTicks(3784), "et.netus.et@outlook.edu", true, "Ralph", "Valdez", false, null, "ET.NETUS.ET@OUTLOOK.EDU", "VLADIMIR", "AQAAAAIAAYagAAAAEBh1wFyCjf5pv8IkTkz2Gqw9BJl6c7EcYuFpOPm3jPjXtce37zzQIs+ygmHZtTh/BQ==", null, true, null, "fc44523f-1f0d-42bd-91dc-79c46f935abf", false, new DateTime(2024, 2, 25, 18, 10, 10, 45, DateTimeKind.Utc).AddTicks(3786), "Vladimir" },
                    { new Guid("f7975ed3-d1f7-442a-9149-2413f7e37ded"), 0, null, new DateTime(2024, 2, 25, 18, 10, 9, 910, DateTimeKind.Utc).AddTicks(6705), "risus.in@icloud.net", true, "George", "Weber", false, null, "RISUS.IN@ICLOUD.NET", "HU", "AQAAAAIAAYagAAAAEISMODvXn0jivXbaIOzCP+VcbGcoKXBKH08/jhQS6z299xKV/hV9uqU7qkmTrGy7Vw==", null, true, null, "fa581883-8043-4c29-a24a-d99f8e434bf5", false, new DateTime(2024, 2, 25, 18, 10, 9, 910, DateTimeKind.Utc).AddTicks(6707), "Hu" },
                    { new Guid("f8c61f1f-c22e-40f4-9f59-9a3954f86ff6"), 0, null, new DateTime(2024, 2, 25, 18, 10, 9, 745, DateTimeKind.Utc).AddTicks(508), "admin285@gmail.com", true, "Admin", "Admin", false, null, "ADMIN285@GMAIL.COM", "AKIHITOADMIN", "AQAAAAIAAYagAAAAEHBwuz0hGS3UnZRnaxMTfVNqVRDyQLs62rhBbgZrSWnVDxXJCxiFnxuiqJijnwN8Cw==", null, true, null, "0a0d835d-53eb-4b05-80d5-26386bf81328", false, new DateTime(2024, 2, 25, 18, 10, 9, 745, DateTimeKind.Utc).AddTicks(512), "AkihitoAdmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0dc936eb-4177-415d-ae48-4b83133df596"), new Guid("5232a7fa-b52f-4d39-b703-41f4f0bf046f") },
                    { new Guid("0644dff7-fd36-4570-850b-3243fda40864"), new Guid("f8c61f1f-c22e-40f4-9f59-9a3954f86ff6") }
                });
        }
    }
}
