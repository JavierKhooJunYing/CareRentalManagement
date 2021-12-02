using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CareRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "445c24b5-205b-40e4-b154-f43d70c70d94", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "3cfd3062-e04b-4e4d-a7a7-bfc57d30fc1a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f40489e7-6130-4faa-925c-3b8be183aaad", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEFB6TMRP7rFnzA1kRz0TdXK0TzIdkHzFcgLvIJKc/hbHuFvHNHkoqdzpi3Zn+THHGQ==", null, false, "20ca43d8-efd0-4be3-975c-d6b4abbf8e58", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 2, 20, 11, 6, 681, DateTimeKind.Local).AddTicks(6678), new DateTime(2021, 12, 2, 20, 11, 6, 682, DateTimeKind.Local).AddTicks(7708), "Black", "System" },
                    { 2, "System", new DateTime(2021, 12, 2, 20, 11, 6, 682, DateTimeKind.Local).AddTicks(8532), new DateTime(2021, 12, 2, 20, 11, 6, 682, DateTimeKind.Local).AddTicks(8537), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 2, 20, 11, 6, 684, DateTimeKind.Local).AddTicks(138), new DateTime(2021, 12, 2, 20, 11, 6, 684, DateTimeKind.Local).AddTicks(146), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 12, 2, 20, 11, 6, 684, DateTimeKind.Local).AddTicks(150), new DateTime(2021, 12, 2, 20, 11, 6, 684, DateTimeKind.Local).AddTicks(151), "Toyata", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 2, 20, 11, 6, 684, DateTimeKind.Local).AddTicks(3339), new DateTime(2021, 12, 2, 20, 11, 6, 684, DateTimeKind.Local).AddTicks(3345), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 12, 2, 20, 11, 6, 684, DateTimeKind.Local).AddTicks(3348), new DateTime(2021, 12, 2, 20, 11, 6, 684, DateTimeKind.Local).AddTicks(3349), "X5", "System" },
                    { 3, "System", new DateTime(2021, 12, 2, 20, 11, 6, 684, DateTimeKind.Local).AddTicks(3351), new DateTime(2021, 12, 2, 20, 11, 6, 684, DateTimeKind.Local).AddTicks(3352), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 12, 2, 20, 11, 6, 684, DateTimeKind.Local).AddTicks(3354), new DateTime(2021, 12, 2, 20, 11, 6, 684, DateTimeKind.Local).AddTicks(3355), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
