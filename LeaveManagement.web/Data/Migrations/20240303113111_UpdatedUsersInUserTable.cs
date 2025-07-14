using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class UpdatedUsersInUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f9678d8-23ac-4161-b07e-d3d25167dd9c",
                column: "ConcurrencyStamp",
                value: "6695390b-637c-4461-aff3-59ba8b6b35fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f42fada-4765-459e-8455-1153b3691db3",
                column: "ConcurrencyStamp",
                value: "f7a0eaf2-89b1-4cb3-a810-20f1a89a171d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e36a6fd2-7b70-4586-8362-5f11cc8d3588", true, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEL/bkQRJvUjADnsiRIFiC4kPJcIVtTjhT5UpU+MyYufMWqX4lQAAbgXTlYnyVqpdbw==", "a5219226-381a-429b-b85c-91c981fae65f", "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "67d23a95-8d07-4826-a14f-d5001f996426", true, "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEMw2wS/zhTTmipQszSEhneVfPt2D+N62O20VwKvxUaQFpbKOTCBLCiDaVTBgPulfRQ==", "5370e249-ba55-42f1-b8df-497cfbb1c51b", "user@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f9678d8-23ac-4161-b07e-d3d25167dd9c",
                column: "ConcurrencyStamp",
                value: "0818aa29-08ec-4812-9f32-9554d395d0c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f42fada-4765-459e-8455-1153b3691db3",
                column: "ConcurrencyStamp",
                value: "4a46e14b-f0dd-4a85-ad4c-7d1be39ee892");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d57fca2b-8cb6-4ad2-808f-67323ab7d14a", false, null, "AQAAAAEAACcQAAAAEJFdJEScIFFiiWGPQfueIhAszgrOY/knjyQfxldZZps5U8CyWqHz7pBhzhcz648Gbw==", "b84d3f1e-61e5-4b41-bfa5-219f1019b23b", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "93776037-8d6b-47ed-a96f-33760da38de4", false, null, "AQAAAAEAACcQAAAAEGZKnjO5QAURbUoRs43dv9JLlyULlrZ1Z9hkFoFdHa4Jk7Dn/7zoGdQRTyRw86gkiw==", "e36c8b8f-5dfe-4010-b44b-d8e290056ba4", null });
        }
    }
}
