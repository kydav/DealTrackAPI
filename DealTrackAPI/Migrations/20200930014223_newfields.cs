using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DealTrackAPI.Migrations
{
    public partial class newfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OfficeNumber",
                table: "Lenders",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MobileNumber",
                table: "Lenders",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "FaxNumber",
                table: "Lenders",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppraiserId",
                table: "Deals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DisclosureDeadline",
                table: "Deals",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "EarnestMoney",
                table: "Deals",
                type: "decimal(7,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "TitleCompanyId",
                table: "Deals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Appraiser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    BusinessName = table.Column<string>(maxLength: 50, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    AddressOne = table.Column<string>(maxLength: 50, nullable: false),
                    AddressTwo = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 5, nullable: false),
                    OfficeNumber = table.Column<string>(maxLength: 50, nullable: true),
                    MobileNumber = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appraiser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TitleCompany",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    AddressOne = table.Column<string>(maxLength: 50, nullable: false),
                    AddressTwo = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 5, nullable: false),
                    OfficeNumber = table.Column<string>(maxLength: 50, nullable: true),
                    FaxNumber = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleCompany", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Appraiser",
                columns: new[] { "Id", "AddressOne", "AddressTwo", "BusinessName", "City", "EmailAddress", "MobileNumber", "Name", "OfficeNumber", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "107 N. 200 W.", null, "Utah South Appraisal", "Cedar City", "kreed@utahsouthappraisal.com", "435-531-9683", "Karsten Reed", "435-865-1921", "UT", "84720" },
                    { 2, "337 S. Main St.", "Ste 122", "Hymas & Associates", "Cedar City", "cody@hymasappraisal.com", null, null, "435-313-1444", "UT", "84720" }
                });

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 1, 1 },
                column: "Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 2, 1 },
                column: "Id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 3, 2 },
                column: "Id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 4, 2 },
                column: "Id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 5, 3 },
                column: "Id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 6, 4 },
                column: "Id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 7, 1 },
                column: "Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 8, 2 },
                column: "Id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 9, 3 },
                column: "Id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 10, 4 },
                column: "Id",
                value: 9);

            migrationBuilder.InsertData(
                table: "TitleCompany",
                columns: new[] { "Id", "AddressOne", "AddressTwo", "City", "EmailAddress", "FaxNumber", "Name", "OfficeNumber", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "210 North 300 West", "Ste 100", "Cedar City", null, "435-586-5141", "Southern Utah Title Company", "435-586-9414", "UT", "84720" },
                    { 2, "365 S Main St", null, "Cedar City", null, null, "First American Title Company", "435-586-4476", "UT", "84720" }
                });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppraiserId", "DisclosureDeadline", "EarnestMoney", "TitleCompanyId" },
                values: new object[] { 1, new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1300m, 2 });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppraiserId", "EarnestMoney", "TitleCompanyId" },
                values: new object[] { 2, 5000m, 2 });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppraiserId", "EarnestMoney", "TitleCompanyId" },
                values: new object[] { 2, 2000m, 1 });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppraiserId", "EarnestMoney", "TitleCompanyId" },
                values: new object[] { 1, 500m, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Deals_AppraiserId",
                table: "Deals",
                column: "AppraiserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_TitleCompanyId",
                table: "Deals",
                column: "TitleCompanyId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Appraiser_AppraiserId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_TitleCompany_TitleCompanyId",
                table: "Deals");

            migrationBuilder.DropTable(
                name: "Appraiser");

            migrationBuilder.DropTable(
                name: "TitleCompany");

            migrationBuilder.DropIndex(
                name: "IX_Deals_AppraiserId",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Deals_TitleCompanyId",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "FaxNumber",
                table: "Lenders");

            migrationBuilder.DropColumn(
                name: "AppraiserId",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "DisclosureDeadline",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "EarnestMoney",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "TitleCompanyId",
                table: "Deals");

            migrationBuilder.AlterColumn<string>(
                name: "OfficeNumber",
                table: "Lenders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MobileNumber",
                table: "Lenders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 1, 1 },
                column: "Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 2, 1 },
                column: "Id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 3, 2 },
                column: "Id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 4, 2 },
                column: "Id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 5, 3 },
                column: "Id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 6, 4 },
                column: "Id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 7, 1 },
                column: "Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 8, 2 },
                column: "Id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 9, 3 },
                column: "Id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CustomersToDeals",
                keyColumns: new[] { "CustomerId", "DealId" },
                keyValues: new object[] { 10, 4 },
                column: "Id",
                value: 9);
        }
    }
}
