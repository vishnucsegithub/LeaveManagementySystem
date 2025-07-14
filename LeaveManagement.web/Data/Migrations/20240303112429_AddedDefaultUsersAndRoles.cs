using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f9678d8-23ac-4161-b07e-d3d25167dd9c", "0818aa29-08ec-4812-9f32-9554d395d0c7", "User", "USER" },
                    { "4f42fada-4765-459e-8455-1153b3691db3", "4a46e14b-f0dd-4a85-ad4c-7d1be39ee892", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4", 0, "d57fca2b-8cb6-4ad2-808f-67323ab7d14a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "admin", "LMS", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEJFdJEScIFFiiWGPQfueIhAszgrOY/knjyQfxldZZps5U8CyWqHz7pBhzhcz648Gbw==", null, false, "b84d3f1e-61e5-4b41-bfa5-219f1019b23b", null, false, null },
                    { "650c2894-3d0c-40ff-9a31-9aa0cae71932", 0, "93776037-8d6b-47ed-a96f-33760da38de4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", false, "user", "LMS", false, null, "USER@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGZKnjO5QAURbUoRs43dv9JLlyULlrZ1Z9hkFoFdHa4Jk7Dn/7zoGdQRTyRw86gkiw==", null, false, "e36c8b8f-5dfe-4010-b44b-d8e290056ba4", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4f42fada-4765-459e-8455-1153b3691db3", "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2f9678d8-23ac-4161-b07e-d3d25167dd9c", "650c2894-3d0c-40ff-9a31-9aa0cae71932" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f42fada-4765-459e-8455-1153b3691db3", "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f9678d8-23ac-4161-b07e-d3d25167dd9c", "650c2894-3d0c-40ff-9a31-9aa0cae71932" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f9678d8-23ac-4161-b07e-d3d25167dd9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f42fada-4765-459e-8455-1153b3691db3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932");
        }
    }
}
