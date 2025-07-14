using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class Thisisfirstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f9678d8-23ac-4161-b07e-d3d25167dd9c",
                column: "ConcurrencyStamp",
                value: "6f7c5873-b583-4cca-ac52-da92b70c9f4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f42fada-4765-459e-8455-1153b3691db3",
                column: "ConcurrencyStamp",
                value: "abd51d8d-75ea-442a-b30b-b98992403c77");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbd5d835-1c43-48d7-8742-c1072783e5e9", "AQAAAAEAACcQAAAAEPqIlHcRCIVvMMUQHhPOnUfst2WhbE5R0qjd5ky4dEzXDUQ4gZpJ02Fn+j9f0l35NQ==", "cc371349-aa32-4671-988f-e35f50aa0237" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afd299f2-9dd2-434a-a0de-a4113b2b9ba4", "AQAAAAEAACcQAAAAEMIG6+sBV01j6IyjOJMDsQiGKtQFWeZ5F/5P4AGXtwWOE5Hs0qodwvtAN0ff2cVTyQ==", "7b792bed-4dc3-404a-a764-8fa7ad3d1d6b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f9678d8-23ac-4161-b07e-d3d25167dd9c",
                column: "ConcurrencyStamp",
                value: "90859657-2407-4f7d-ad8f-88765b7aec15");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f42fada-4765-459e-8455-1153b3691db3",
                column: "ConcurrencyStamp",
                value: "cab3a3e7-4bcc-44bc-a157-a99e12d2721f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85504aa7-6e52-4b6c-be64-24cd75a35e95", "AQAAAAEAACcQAAAAEBQE+1ETJgQIWWB05ayEwrY+5vWnLaF+2Y9TmuP3FSaSaihC3OYWuhMKUqMDU/Uw4Q==", "8e1315c7-cf65-4692-b589-6c19d86e469d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70cfbd42-73c3-40bc-a883-3414f8d15e3d", "AQAAAAEAACcQAAAAECwGSHSwDiCjLo4uknf1bUFZKunrDNDC0uPK8febIRsS8tXIJj+tpWa4gH/GsbeZPQ==", "cd0cffb9-1789-45d0-84ee-25d520633125" });
        }
    }
}
