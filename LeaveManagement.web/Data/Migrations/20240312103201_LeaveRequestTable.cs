using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class LeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestedEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f9678d8-23ac-4161-b07e-d3d25167dd9c",
                column: "ConcurrencyStamp",
                value: "3509fbce-a400-4c0f-b1da-ca6fa71b3f90");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f42fada-4765-459e-8455-1153b3691db3",
                column: "ConcurrencyStamp",
                value: "a0b8c9d4-7cba-4531-8095-917fdb7558f9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aaa3d63a-bfbc-4a0d-9633-14c6cc075ec2", "AQAAAAEAACcQAAAAEJ3fuQsV9mZHLwN2oU9uWD0KHteAQ83qEEoR+gWgNQQSKnjDd/DC0P54ksMr436zyA==", "eb25901e-8f85-4068-bcfc-9da0ea268c4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ac27105-7109-4da1-99aa-d33299f5f1f9", "AQAAAAEAACcQAAAAEMTWBHHKNI5kEtT45dpfm2xfhKpZIb44q4z5goKUj5375UtLh+Pvz1deYuCmfxYNLg==", "2035877a-e934-4fc4-9aa0-7a2735a86c51" });
        }
    }
}
