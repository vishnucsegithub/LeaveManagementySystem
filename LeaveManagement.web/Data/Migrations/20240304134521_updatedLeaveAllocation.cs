using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class updatedLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f9678d8-23ac-4161-b07e-d3d25167dd9c",
                column: "ConcurrencyStamp",
                value: "4509c00e-065c-4dd2-a9c6-74e82466929a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f42fada-4765-459e-8455-1153b3691db3",
                column: "ConcurrencyStamp",
                value: "73078185-0a33-4279-9646-e470e5c14d34");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9df4e63-87b7-4dfb-b8e3-ff330851bbf4", "AQAAAAEAACcQAAAAEJlbp2TqI10osNxzQz9Qnz9vHm5UIjM6/k5fVcFDusfcfDJAx0isIVrGiRb68iD/iw==", "8b0a442b-e07f-4c4d-a97f-f5224ec08ac8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce929aa1-0af6-4a98-a6bd-139fe3ceb446", "AQAAAAEAACcQAAAAEKe0ai6e6nrFyxP4fCfqJ46EGdN2+Qrpi5yFACaUA5b9mtDOfi3gtBkJWq18xj0dMw==", "85e24421-7bdc-4326-b856-1021f6925f0e" });
        }
    }
}
