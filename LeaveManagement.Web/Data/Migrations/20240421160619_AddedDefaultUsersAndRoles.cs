using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a58b2352-2da1-1120-be1e-1fb56ddd90c8", null, "User", "USER" },
                    { "d65b2352-24f3-4120-ae1e-1fb56ddd90c8", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9c18b0df-c7bb-4abd-a294-e387c54b0548", 0, "73343c77-50be-4722-9d8d-8573f3e26abc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", false, "user", "user", false, null, "USER@GMAIL.COM", null, "AQAAAAIAAYagAAAAEMaVJ98KbqbCSVRBY9NQDFl4fvI4fN5L8JGVBsrygljh6RqKxiP6BtwEadpjwzPN9Q==", null, false, "e9bf6b37-788c-4f50-b9d0-0ccb67500d08", null, false, null },
                    { "fe0da13d-266b-43e1-916e-99a1c2ec6c17", 0, "37e8d552-6f0a-4421-a42e-b01eab44c09d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "admin", "admin", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAIAAYagAAAAEM0JlaGbMy/9j3miRnvnBgQ38puQSFIp85tPQvExOikFjASPqiYlJjoTsJ7dINMQKg==", null, false, "c341d4e1-c236-46f3-ac3a-bb484a789756", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a58b2352-2da1-1120-be1e-1fb56ddd90c8", "9c18b0df-c7bb-4abd-a294-e387c54b0548" },
                    { "d65b2352-24f3-4120-ae1e-1fb56ddd90c8", "fe0da13d-266b-43e1-916e-99a1c2ec6c17" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a58b2352-2da1-1120-be1e-1fb56ddd90c8", "9c18b0df-c7bb-4abd-a294-e387c54b0548" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d65b2352-24f3-4120-ae1e-1fb56ddd90c8", "fe0da13d-266b-43e1-916e-99a1c2ec6c17" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a58b2352-2da1-1120-be1e-1fb56ddd90c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d65b2352-24f3-4120-ae1e-1fb56ddd90c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c18b0df-c7bb-4abd-a294-e387c54b0548");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe0da13d-266b-43e1-916e-99a1c2ec6c17");
        }
    }
}
