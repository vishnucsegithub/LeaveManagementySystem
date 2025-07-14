using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class UpdatedLeaveAllocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e36a6fd2-7b70-4586-8362-5f11cc8d3588", "AQAAAAEAACcQAAAAEL/bkQRJvUjADnsiRIFiC4kPJcIVtTjhT5UpU+MyYufMWqX4lQAAbgXTlYnyVqpdbw==", "a5219226-381a-429b-b85c-91c981fae65f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67d23a95-8d07-4826-a14f-d5001f996426", "AQAAAAEAACcQAAAAEMw2wS/zhTTmipQszSEhneVfPt2D+N62O20VwKvxUaQFpbKOTCBLCiDaVTBgPulfRQ==", "5370e249-ba55-42f1-b8df-497cfbb1c51b" });
        }
    }
}
