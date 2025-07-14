using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f9678d8-23ac-4161-b07e-d3d25167dd9c",
                column: "ConcurrencyStamp",
                value: "08b1f789-cf59-4d66-9f41-f60ab8173593");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f42fada-4765-459e-8455-1153b3691db3",
                column: "ConcurrencyStamp",
                value: "a894b0ed-819c-4a3c-9787-fa87c41daf7d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7df713e-95f6-439c-98e8-16d424d1d987", "AQAAAAEAACcQAAAAECKb48F+jQFavJdTg7PhVzor4bJ6ST5KM5DggSRpkZkjnQImRalXiThMGLbEFsOA4A==", "0e4bea19-33b6-453e-b7fc-8303117e5c67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b38750e-772e-4d31-83cb-100cec20154f", "AQAAAAEAACcQAAAAENsJGMMLmBUhMpvPRWnwyeVFjwdc8xIRboKBYig5pSk14LbWaZF4SDNLaOnXmFhIkQ==", "1ff0c61f-3455-467f-a64d-9dc090a13cbc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
