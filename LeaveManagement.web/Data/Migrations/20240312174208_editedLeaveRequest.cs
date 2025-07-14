using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class editedLeaveRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f9678d8-23ac-4161-b07e-d3d25167dd9c",
                column: "ConcurrencyStamp",
                value: "19731f92-1cd2-4c55-9fdd-f7df38b0ee59");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f42fada-4765-459e-8455-1153b3691db3",
                column: "ConcurrencyStamp",
                value: "7074469a-131e-4747-8903-3b513b987b2c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab56f89d-056a-4e7b-b6f9-f416662bb46d", "AQAAAAEAACcQAAAAEPnml0xZH5srzv28pxpx7VAipKfl1fw/PesfHZJOW2CAZ7JjYyzBheFCs12vQN480w==", "536de1ef-7ab1-4008-be00-f0341ec3342b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2caa7294-ca71-4800-87ca-5cd5e6edf181", "AQAAAAEAACcQAAAAEPO9iErrG5dUcD2mAaJ9+GVRH4E5bU/2EadOMbiAj4tzyHfoH74iDMJbfpzVgijemA==", "0429764f-9bcc-4c97-8b4c-f8a4a680e602" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f9678d8-23ac-4161-b07e-d3d25167dd9c",
                column: "ConcurrencyStamp",
                value: "185f4300-ac09-455e-8c5c-d1b10957b4cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f42fada-4765-459e-8455-1153b3691db3",
                column: "ConcurrencyStamp",
                value: "0c5ac3db-cc9a-4d50-8491-1c97c0f85a9a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79173755-d6ec-4ebd-9519-e8e1496c1210", "AQAAAAEAACcQAAAAECSP8cwTt6xnK/GJe6mNuAwCcyh8HkobVdvWf5R6wd6qz3Gqfmw6VIPshzmESc14Cg==", "efe5f400-d372-49dc-9b84-954b492c8314" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb5b9a9f-79d0-413e-8daa-ab4da3f1843e", "AQAAAAEAACcQAAAAEDWgcw5exuftnCxNDDEUzlZAEbAmyjrCEteJpNn7hETI3QUHWVoWRZWvUDMU070R4Q==", "59b1c90c-8ec1-4381-a344-bef270ddc117" });
        }
    }
}
