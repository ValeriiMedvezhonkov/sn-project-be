using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sn_project_be.Migrations
{
    /// <inheritdoc />
    public partial class FixNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("cae420fb-001a-4df1-9ca0-dbd841ef22ac"), new Guid("5a49c82b-4f25-4e93-84e7-a24df464a72b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("bd7a7276-168d-40c4-88c6-fa809993b6e1"), new Guid("bdbb9a8a-7019-4d8f-bd96-120b6cb6af2c") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("04ca7b0a-b838-4b33-a001-cbfa49c40468"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("115e991b-dbea-43f6-aa20-b2045fd2d36d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3c08cfab-d72e-450a-8c64-1f82ab7c16f4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3daa663d-0bdf-43ea-8f0e-ab3ecfccb4d1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5fbed1ed-1d3b-4b10-9ff7-4a2a816ad3e7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6c5f6c63-741d-4439-86f8-03e7e1384b44"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("757bdcc6-ce69-4d3a-b2fd-7d39d028ba4c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("77d631fc-74c3-4973-bb0b-a331337df9e5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("86a7e0c9-076a-4097-9b0f-95115bcc2ec8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9befd394-2945-4560-94b4-53f24c61b585"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a8835b47-914d-484e-8756-cada0c2b4dd8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afcfc171-05f6-46bb-b323-96f56a218a98"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b74f0ac7-6d19-4d8f-bd5d-1a5d7335d3df"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8210314-bb0a-4296-9ec5-a4142246cea0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("becfe44b-4347-4bc5-81f6-0cf3244ddd76"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c617bc9d-a82e-4cdb-9ed3-e20b17f530bb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d136aab8-52d9-457f-8481-642016d2b35b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d6f47b21-0b09-4413-9d34-344f9cb2539e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea89b3a0-ff62-4425-bbef-a820fa67bb3e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f80ff19f-4a2f-4f37-abc6-236b9d096611"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bd7a7276-168d-40c4-88c6-fa809993b6e1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cae420fb-001a-4df1-9ca0-dbd841ef22ac"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5a49c82b-4f25-4e93-84e7-a24df464a72b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdbb9a8a-7019-4d8f-bd96-120b6cb6af2c"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
