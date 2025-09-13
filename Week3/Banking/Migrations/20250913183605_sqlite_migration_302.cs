using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Banking.Migrations
{
    /// <inheritdoc />
    public partial class sqlite_migration_302 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccount_AccountHolder_AccountHolderId",
                table: "BankAccount");

            migrationBuilder.AlterColumn<int>(
                name: "AccountHolderId",
                table: "BankAccount",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccount_AccountHolder_AccountHolderId",
                table: "BankAccount",
                column: "AccountHolderId",
                principalTable: "AccountHolder",
                principalColumn: "AccountHolderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccount_AccountHolder_AccountHolderId",
                table: "BankAccount");

            migrationBuilder.AlterColumn<int>(
                name: "AccountHolderId",
                table: "BankAccount",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccount_AccountHolder_AccountHolderId",
                table: "BankAccount",
                column: "AccountHolderId",
                principalTable: "AccountHolder",
                principalColumn: "AccountHolderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
