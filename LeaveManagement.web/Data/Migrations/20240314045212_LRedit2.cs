using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class LRedit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequestedEmployeeId",
                table: "LeaveRequests",
                newName: "RequestingEmployeeId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                newName: "RequestedEmployeeId");

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
    }
}
