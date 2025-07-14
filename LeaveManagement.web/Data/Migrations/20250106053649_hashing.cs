using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class hashing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f9678d8-23ac-4161-b07e-d3d25167dd9c",
                column: "ConcurrencyStamp",
                value: "b1714b7a-6fed-42f8-8302-c80b3cd9e9e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f42fada-4765-459e-8455-1153b3691db3",
                column: "ConcurrencyStamp",
                value: "851632c3-c149-47b8-bd5c-621cbe032a07");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "86a5823a-aa85-458f-b344-fd71353550fd", "admin1@gmail.com", "ADMIN1@GMAIL.COM", "ADMIN1@GMAIL.COM", "Abcde12345@", "6587348e-8648-49bf-8645-9f6065b31482", "admin1@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19a41792-dd82-44e5-96fb-24168ef0557a", "AQAAAAEAACcQAAAAECYPz5sI0GIbfwvy2B69rdGgylDp59EYQYAZ2WC/JAPlIuFYO5oG7YuFuvA16Vl4KA==", "32086b20-4585-4db1-be89-f42f283f4581" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a7df713e-95f6-439c-98e8-16d424d1d987", "admin@gmail.com", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECKb48F+jQFavJdTg7PhVzor4bJ6ST5KM5DggSRpkZkjnQImRalXiThMGLbEFsOA4A==", "0e4bea19-33b6-453e-b7fc-8303117e5c67", "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b38750e-772e-4d31-83cb-100cec20154f", "AQAAAAEAACcQAAAAENsJGMMLmBUhMpvPRWnwyeVFjwdc8xIRboKBYig5pSk14LbWaZF4SDNLaOnXmFhIkQ==", "1ff0c61f-3455-467f-a64d-9dc090a13cbc" });
        }
    }
}
