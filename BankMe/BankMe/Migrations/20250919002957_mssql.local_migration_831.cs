using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankMe.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_831 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AccountHolder",
                newName: "AccountHolderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AccountHolderId",
                table: "AccountHolder",
                newName: "Id");
        }
    }
}
