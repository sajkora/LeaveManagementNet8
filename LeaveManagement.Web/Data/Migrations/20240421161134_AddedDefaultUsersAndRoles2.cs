using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c18b0df-c7bb-4abd-a294-e387c54b0548",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a6d72200-6260-4bdd-b5aa-f6f4ebaa0011", true, "USER@GMAIL.COM", "AQAAAAIAAYagAAAAEPl9Z1Pj8uIgLkhMrNVCzs1GzOnyunEa1io2e5Kn/6uRnd9uGUQD+wmkX5rmA7sDIg==", "41b71447-eb8d-441d-bb73-4e3283cad5c8", "user@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe0da13d-266b-43e1-916e-99a1c2ec6c17",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b07d753a-0add-445a-8a25-409f3bc9a208", true, "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEIAtmqPRUPL5RUQ8Q1s79I2fbU1079EFXKM7ZalJk8KolrVD+7KYmws9A+LStx6y4g==", "2fadc6ed-aa22-457f-abec-0b8d855c56e0", "admin@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c18b0df-c7bb-4abd-a294-e387c54b0548",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "73343c77-50be-4722-9d8d-8573f3e26abc", false, null, "AQAAAAIAAYagAAAAEMaVJ98KbqbCSVRBY9NQDFl4fvI4fN5L8JGVBsrygljh6RqKxiP6BtwEadpjwzPN9Q==", "e9bf6b37-788c-4f50-b9d0-0ccb67500d08", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe0da13d-266b-43e1-916e-99a1c2ec6c17",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "37e8d552-6f0a-4421-a42e-b01eab44c09d", false, null, "AQAAAAIAAYagAAAAEM0JlaGbMy/9j3miRnvnBgQ38puQSFIp85tPQvExOikFjASPqiYlJjoTsJ7dINMQKg==", "c341d4e1-c236-46f3-ac3a-bb484a789756", null });
        }
    }
}
