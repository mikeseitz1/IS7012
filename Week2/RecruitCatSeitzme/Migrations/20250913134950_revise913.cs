using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatSeitzme.Migrations
{
    /// <inheritdoc />
    public partial class revise913 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Company_CompanyId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_JobTitle_JobTitleId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Industry_IndustryID",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "Industry",
                table: "Candidate");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "JobTitle",
                newName: "JobName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "JobTitle",
                newName: "JobDescription");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Industry",
                newName: "IndustryName");

            migrationBuilder.RenameColumn(
                name: "IndustryID",
                table: "Company",
                newName: "IndustryId");

            migrationBuilder.RenameIndex(
                name: "IX_Company_IndustryID",
                table: "Company",
                newName: "IX_Company_IndustryId");

            migrationBuilder.RenameColumn(
                name: "JobTitleId",
                table: "Candidate",
                newName: "JobNameId");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Candidate",
                newName: "CompanyNameCompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_JobTitleId",
                table: "Candidate",
                newName: "IX_Candidate_JobNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_CompanyId",
                table: "Candidate",
                newName: "IX_Candidate_CompanyNameCompanyId");

            migrationBuilder.AlterColumn<int>(
                name: "IndustryId",
                table: "Candidate",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Company_CompanyNameCompanyId",
                table: "Candidate",
                column: "CompanyNameCompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_JobTitle_JobNameId",
                table: "Candidate",
                column: "JobNameId",
                principalTable: "JobTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Industry_IndustryId",
                table: "Company",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Company_CompanyNameCompanyId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_JobTitle_JobNameId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Industry_IndustryId",
                table: "Company");

            migrationBuilder.RenameColumn(
                name: "JobName",
                table: "JobTitle",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "JobDescription",
                table: "JobTitle",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "IndustryName",
                table: "Industry",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "IndustryId",
                table: "Company",
                newName: "IndustryID");

            migrationBuilder.RenameIndex(
                name: "IX_Company_IndustryId",
                table: "Company",
                newName: "IX_Company_IndustryID");

            migrationBuilder.RenameColumn(
                name: "JobNameId",
                table: "Candidate",
                newName: "JobTitleId");

            migrationBuilder.RenameColumn(
                name: "CompanyNameCompanyId",
                table: "Candidate",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_JobNameId",
                table: "Candidate",
                newName: "IX_Candidate_JobTitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_CompanyNameCompanyId",
                table: "Candidate",
                newName: "IX_Candidate_CompanyId");

            migrationBuilder.AlterColumn<int>(
                name: "IndustryId",
                table: "Candidate",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Candidate",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Industry",
                table: "Candidate",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Company_CompanyId",
                table: "Candidate",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_JobTitle_JobTitleId",
                table: "Candidate",
                column: "JobTitleId",
                principalTable: "JobTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Industry_IndustryID",
                table: "Company",
                column: "IndustryID",
                principalTable: "Industry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
