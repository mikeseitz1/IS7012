using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatSeitzme.Migrations
{
    /// <inheritdoc />
    public partial class update9131100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Company_CompanyNameCompanyId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_JobTitle_JobNameId",
                table: "Candidate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "JobTitle",
                newName: "JobTitleId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Industry",
                newName: "IndustryId");

            migrationBuilder.RenameColumn(
                name: "JobNameId",
                table: "Candidate",
                newName: "JobTitleId");

            migrationBuilder.RenameColumn(
                name: "CompanyNameCompanyId",
                table: "Candidate",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Candidate",
                newName: "CandidateId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_JobNameId",
                table: "Candidate",
                newName: "IX_Candidate_JobTitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_CompanyNameCompanyId",
                table: "Candidate",
                newName: "IX_Candidate_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Company_CompanyId",
                table: "Candidate",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_JobTitle_JobTitleId",
                table: "Candidate",
                column: "JobTitleId",
                principalTable: "JobTitle",
                principalColumn: "JobTitleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Company_CompanyId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_JobTitle_JobTitleId",
                table: "Candidate");

            migrationBuilder.RenameColumn(
                name: "JobTitleId",
                table: "JobTitle",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IndustryId",
                table: "Industry",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "JobTitleId",
                table: "Candidate",
                newName: "JobNameId");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Candidate",
                newName: "CompanyNameCompanyId");

            migrationBuilder.RenameColumn(
                name: "CandidateId",
                table: "Candidate",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_JobTitleId",
                table: "Candidate",
                newName: "IX_Candidate_JobNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_CompanyId",
                table: "Candidate",
                newName: "IX_Candidate_CompanyNameCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Company_CompanyNameCompanyId",
                table: "Candidate",
                column: "CompanyNameCompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_JobTitle_JobNameId",
                table: "Candidate",
                column: "JobNameId",
                principalTable: "JobTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
