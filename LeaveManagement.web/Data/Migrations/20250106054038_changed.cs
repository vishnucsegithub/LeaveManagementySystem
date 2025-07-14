using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f9678d8-23ac-4161-b07e-d3d25167dd9c",
                column: "ConcurrencyStamp",
                value: "e36dcc82-e61b-4f20-8910-bc669e793a7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f42fada-4765-459e-8455-1153b3691db3",
                column: "ConcurrencyStamp",
                value: "5fe20850-9e4a-4fa8-ac53-41b7f3643997");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8aa07af8-d8ad-4b23-8f79-b746399aff2a", "AQAAAAEAACcQAAAAEGULND7fvJMnAuBMrz6AqvFfnWDcihyUbahZBhLFexFAB5TENWYztRguGO5HA1dXqw==", "c9a77a9f-d2c8-40b2-b6fc-a94c0b260de4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46cd378f-51cd-4877-befe-a9705e69c866", "AQAAAAEAACcQAAAAEK+LyIjEu2IDG1MIO77GIu1jwpeGf/4fiYkDYCVdBBUZJ7PTRMFt3tottx1AF4E9lA==", "85e228c5-d202-4233-808a-ae45216a490e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86a5823a-aa85-458f-b344-fd71353550fd", "Abcde12345@", "6587348e-8648-49bf-8645-9f6065b31482" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "650c2894-3d0c-40ff-9a31-9aa0cae71932",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19a41792-dd82-44e5-96fb-24168ef0557a", "AQAAAAEAACcQAAAAECYPz5sI0GIbfwvy2B69rdGgylDp59EYQYAZ2WC/JAPlIuFYO5oG7YuFuvA16Vl4KA==", "32086b20-4585-4db1-be89-f42f283f4581" });
        }
    }
}
