using Microsoft.EntityFrameworkCore.Migrations;

namespace DealTrackAPI.Migrations
{
    public partial class migrate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Appraiser_AppraiserId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_TitleCompany_TitleCompanyId",
                table: "Deals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TitleCompany",
                table: "TitleCompany");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appraiser",
                table: "Appraiser");

            migrationBuilder.RenameTable(
                name: "TitleCompany",
                newName: "TitleCompanies");

            migrationBuilder.RenameTable(
                name: "Appraiser",
                newName: "Appraisers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TitleCompanies",
                table: "TitleCompanies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appraisers",
                table: "Appraisers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 1, 1 },
                column: "Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 2, 1 },
                column: "Id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 3, 2 },
                column: "Id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 4, 2 },
                column: "Id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 5, 3 },
                column: "Id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 6, 4 },
                column: "Id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 7, 1 },
                column: "Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 8, 2 },
                column: "Id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 9, 3 },
                column: "Id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 10, 4 },
                column: "Id",
                value: 9);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Appraisers_AppraiserId",
                table: "Deals",
                column: "AppraiserId",
                principalTable: "Appraisers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_TitleCompanies_TitleCompanyId",
                table: "Deals",
                column: "TitleCompanyId",
                principalTable: "TitleCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Appraisers_AppraiserId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_TitleCompanies_TitleCompanyId",
                table: "Deals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TitleCompanies",
                table: "TitleCompanies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appraisers",
                table: "Appraisers");

            migrationBuilder.RenameTable(
                name: "TitleCompanies",
                newName: "TitleCompany");

            migrationBuilder.RenameTable(
                name: "Appraisers",
                newName: "Appraiser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TitleCompany",
                table: "TitleCompany",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appraiser",
                table: "Appraiser",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 1, 1 },
                column: "Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 2, 1 },
                column: "Id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 3, 2 },
                column: "Id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 4, 2 },
                column: "Id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 5, 3 },
                column: "Id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 6, 4 },
                column: "Id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 7, 1 },
                column: "Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 8, 2 },
                column: "Id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 9, 3 },
                column: "Id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CustomerDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 10, 4 },
                column: "Id",
                value: 9);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Appraiser_AppraiserId",
                table: "Deals",
                column: "AppraiserId",
                principalTable: "Appraiser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_TitleCompany_TitleCompanyId",
                table: "Deals",
                column: "TitleCompanyId",
                principalTable: "TitleCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
