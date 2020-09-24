using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DealTrackAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    AddressOne = table.Column<string>(maxLength: 50, nullable: true),
                    AddressTwo = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    State = table.Column<string>(maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 5, nullable: true),
                    OfficeNumber = table.Column<string>(maxLength: 50, nullable: true),
                    MobileNumber = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressOne = table.Column<string>(maxLength: 50, nullable: false),
                    AddressTwo = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 5, nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    UserGuid = table.Column<Guid>(nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(nullable: false),
                    PropertyId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    LenderID = table.Column<int>(nullable: false),
                    CreatorId = table.Column<int>(nullable: false),
                    AssigneeId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    AppraisalDate = table.Column<DateTime>(nullable: false),
                    InspectionDate = table.Column<DateTime>(nullable: false),
                    ClosingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deals_Users_AssigneeId",
                        column: x => x.AssigneeId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deals_Property_Id",
                        column: x => x.Id,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deals_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealId = table.Column<int>(nullable: false),
                    CreatorId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Deals_DealId",
                        column: x => x.DealId,
                        principalTable: "Deals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomersToDeals",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    DealId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsOurcustomer = table.Column<bool>(nullable: false),
                    CustomerType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersToDeals", x => new { x.CustomerId, x.DealId });
                    table.ForeignKey(
                        name: "FK_CustomersToDeals_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersToDeals_Deals_DealId",
                        column: x => x.DealId,
                        principalTable: "Deals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lenders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    BusinessName = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
                    AddressOne = table.Column<string>(maxLength: 50, nullable: false),
                    AddressTwo = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 5, nullable: false),
                    OfficeNumber = table.Column<string>(maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lenders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lenders_Deals_Id",
                        column: x => x.Id,
                        principalTable: "Deals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressOne", "AddressTwo", "City", "EmailAddress", "FirstName", "LastName", "MobileNumber", "OfficeNumber", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "2167 W 100 N", null, "Cedar City", "cbearnson@gmail.com", "Chris", "Bearnson", "435-590-9117", null, "UT", "84720" },
                    { 10, "234 Buying Drive", null, "Cedar City", null, "Buyer", "Two", "222-333-4444", null, "UT", "84720" },
                    { 8, "123 Buying Drive", null, "Cedar City", "buyerone@gmail.com", "Buyer", "One", "098-765-4321", null, "UT", "84720" },
                    { 7, "123 Sales Drive", "ste 34", "Cedar City", "sellerone@gmail.com", "Seller", "One", "123-456-7890", null, "UT", "84720" },
                    { 6, "2000 Corporate Drive", "Apt 1014", "Mission Viejo", "tiffanyinmaui@gmail.com", "Tiffany", "Morris", "949-322-8759", null, "CA", "92694" },
                    { 9, "234 Sales Drive", "ste 34", "Cedar City", null, "Seller", "Two", "111-222-3333", null, "UT", "84720" },
                    { 4, "617 Cove Drive", null, "Cedar City", "mbleaz@gmail.com", "Mauri", "Bleazard", "435-531-1562", null, "UT", "84720" },
                    { 3, "617 Cove Drive", null, "Cedar City", "jbleaz@gmail.com", "Jeff", "Bleazard", "435-531-1563", null, "UT", "84720" },
                    { 2, "2167 W 100 N", null, "Cedar City", "dbearnson@gmail.com", "Day", "Bearnson", "435-590-9118", null, "UT", "84720" },
                    { 5, "1340 Parkside Dr", null, "Cedar City", "ddm@tristate.com", "David", "Morris", "435-559-1996", null, "UT", "84720" }
                });

            migrationBuilder.InsertData(
                table: "Property",
                columns: new[] { "Id", "AddressOne", "AddressTwo", "City", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "2209 Cedar Hill Dr.", null, "Cedar City", "UT", "84720" },
                    { 2, "2216 Cedar Hill Dr.", null, "Cedar City", "UT", "84720" },
                    { 3, "2239 Cedar Hill Dr.", null, "Cedar City", "UT", "84720" },
                    { 4, "171 College Way", "#7", "Cedar City", "UT", "84720" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EmailAddress", "FirstName", "LastName", "MobileNumber", "PasswordHash", "UserGuid", "UserName" },
                values: new object[,]
                {
                    { 3, "billyandjen@gmail.com", "Billy", "Davis", null, null, new Guid("00000000-0000-0000-0000-000000000000"), "bdavis" },
                    { 1, "realtor1jen@gmail.com", "Jennifer", "Davis", null, null, new Guid("00000000-0000-0000-0000-000000000000"), "jdavis" },
                    { 2, "ky.s.dav@gmail.com", "Kyler", "Davis", null, null, new Guid("00000000-0000-0000-0000-000000000000"), "kdavis" },
                    { 4, "pokey757@gmail.com", "Jessica", "Davis", null, null, new Guid("00000000-0000-0000-0000-000000000000"), "jessdavis" }
                });

            migrationBuilder.InsertData(
                table: "Deals",
                columns: new[] { "Id", "AppraisalDate", "AssigneeId", "ClosingDate", "CreatedDate", "CreatorId", "Description", "InspectionDate", "LenderID", "PropertyId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 3 },
                    { 2, new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 3 },
                    { 3, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 3 },
                    { 4, new DateTime(2020, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedDate", "CreatorId", "DealId" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum", new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, "Lorem Ipsum", new DateTime(2020, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 3, "Lorem Ipsum", new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 4, "Lorem Ipsum", new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "CustomersToDeals",
                columns: new[] { "CustomerId", "DealId", "CustomerType", "Id", "IsOurcustomer" },
                values: new object[,]
                {
                    { 1, 1, 0, 1, true },
                    { 2, 1, 0, 2, true },
                    { 7, 1, 1, 3, false },
                    { 8, 2, 0, 4, false },
                    { 3, 2, 1, 5, true },
                    { 4, 2, 1, 6, true },
                    { 5, 3, 0, 7, true },
                    { 9, 3, 1, 8, false },
                    { 10, 4, 0, 9, true },
                    { 6, 4, 1, 10, true }
                });

            migrationBuilder.InsertData(
                table: "Lenders",
                columns: new[] { "Id", "AddressOne", "AddressTwo", "BusinessName", "City", "EmailAddress", "MobileNumber", "Name", "OfficeNumber", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "217 N. 300 West", null, "MGM Mortgage", "Cedar City", "TPrindle@afncorp.com", "435-531-6796", "Tim Prindle", "435-531-6796", "UT", "84721" },
                    { 2, "98 W. Center St.", null, "CityWide Home Loans", "Cedar City", "karl@karlhugh.com", "435-590-1183", "Karl Hugh", "435-590-1183", "UT", "84720" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DealId",
                table: "Comments",
                column: "DealId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersToDeals_DealId",
                table: "CustomersToDeals",
                column: "DealId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_AssigneeId",
                table: "Deals",
                column: "AssigneeId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CustomersToDeals");

            migrationBuilder.DropTable(
                name: "Lenders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Deals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Property");
        }
    }
}
