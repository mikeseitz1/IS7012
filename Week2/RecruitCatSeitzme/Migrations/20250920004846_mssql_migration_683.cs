using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatSeitzme.Migrations
{
    /// <inheritdoc />
    public partial class mssql_migration_683 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "JobSalaryMax",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Candidate");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Candidate",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Candidate",
                newName: "StreetAddress");

            migrationBuilder.AlterColumn<decimal>(
                name: "SalaryMin",
                table: "JobTitle",
                type: "decimal(8,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<decimal>(
                name: "SalaryMax",
                table: "JobTitle",
                type: "decimal(8,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<decimal>(
                name: "SalaryMin",
                table: "Company",
                type: "decimal(8,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "JobStartDate",
                table: "Company",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SalaryMax",
                table: "Company",
                type: "decimal(8,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "IndustryId",
                table: "Candidate",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Candidate",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Candidate",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Candidate",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SocialSecurityNumber",
                table: "Candidate",
                type: "TEXT",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Candidate",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "IndustryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "SalaryMax",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "SocialSecurityNumber",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Candidate");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Candidate",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "Candidate",
                newName: "Address");

            migrationBuilder.AlterColumn<decimal>(
                name: "SalaryMin",
                table: "JobTitle",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SalaryMax",
                table: "JobTitle",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SalaryMin",
                table: "Company",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "JobStartDate",
                table: "Company",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<decimal>(
                name: "JobSalaryMax",
                table: "Company",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "IndustryId",
                table: "Candidate",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Candidate",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "IndustryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
