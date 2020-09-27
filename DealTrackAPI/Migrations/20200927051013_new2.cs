using Microsoft.EntityFrameworkCore.Migrations;

namespace DealTrackAPI.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Users_AssigneeId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Property_Id",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Users_Id",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Lenders_Deals_Id",
                table: "Lenders");

            migrationBuilder.DropIndex(
                name: "IX_Deals_AssigneeId",
                table: "Deals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property",
                table: "Property");

            migrationBuilder.RenameTable(
                name: "Property",
                newName: "Properties");

            migrationBuilder.AddColumn<int>(
                name: "DealAssigneeId",
                table: "Deals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DealCreatorId",
                table: "Deals",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "Id");

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

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssigneeId", "LenderID" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 2,
                column: "LenderID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 3,
                column: "LenderID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 4,
                column: "LenderID",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Deals_DealAssigneeId",
                table: "Deals",
                column: "DealAssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_DealCreatorId",
                table: "Deals",
                column: "DealCreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_LenderID",
                table: "Deals",
                column: "LenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_PropertyId",
                table: "Deals",
                column: "PropertyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CreatorId",
                table: "Comments",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_CreatorId",
                table: "Comments",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Users_DealAssigneeId",
                table: "Deals",
                column: "DealAssigneeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Users_DealCreatorId",
                table: "Deals",
                column: "DealCreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Lenders_LenderID",
                table: "Deals",
                column: "LenderID",
                principalTable: "Lenders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Properties_PropertyId",
                table: "Deals",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_CreatorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Users_DealAssigneeId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Users_DealCreatorId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Lenders_LenderID",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Properties_PropertyId",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Deals_DealAssigneeId",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Deals_DealCreatorId",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Deals_LenderID",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Deals_PropertyId",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CreatorId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "DealAssigneeId",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "DealCreatorId",
                table: "Deals");

            migrationBuilder.RenameTable(
                name: "Properties",
                newName: "Property");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property",
                table: "Property",
                column: "Id");

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

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssigneeId", "LenderID" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 2,
                column: "LenderID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 3,
                column: "LenderID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 4,
                column: "LenderID",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Deals_AssigneeId",
                table: "Deals",
                column: "AssigneeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Users_AssigneeId",
                table: "Deals",
                column: "AssigneeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Property_Id",
                table: "Deals",
                column: "Id",
                principalTable: "Property",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Users_Id",
                table: "Deals",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lenders_Deals_Id",
                table: "Lenders",
                column: "Id",
                principalTable: "Deals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
