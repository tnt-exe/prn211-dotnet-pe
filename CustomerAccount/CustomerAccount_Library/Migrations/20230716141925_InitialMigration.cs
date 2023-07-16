using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerAccount_Library.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CustomerDesc = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserRole = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAccounts",
                columns: table => new
                {
                    AccountID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    OpenDate = table.Column<DateTime>(type: "date", nullable: true),
                    RegionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__349DA586ADA5C598", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK__CustomerA__Custo__286302EC",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "CustomerDesc", "CustomerName" },
                values: new object[,]
                {
                    { "CUST0001", "Detail Linh Description", "Linh Nguyen Thuy" },
                    { "CUST0002", "Detail Hai Description", "Hai Phan Van" },
                    { "CUST0003", "Detail Dong Description", "Dong Bui Huu" },
                    { "CUST0004", "Detail Yen Description", "Yen Nguyen" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Password", "UserName", "UserRole" },
                values: new object[,]
                {
                    { "admin", "123", "Administrator", 1 },
                    { "manager", "123", "Manager", 2 },
                    { "staff", "123", "Staff", 3 }
                });

            migrationBuilder.InsertData(
                table: "CustomerAccounts",
                columns: new[] { "AccountID", "AccountName", "CustomerID", "OpenDate", "RegionName" },
                values: new object[,]
                {
                    { "ACCT0001", "Saving For New Customer 1", "CUST0001", new DateTime(2001, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern Ha Noi" },
                    { "ACCT0002", "Checking For New Customer 1", "CUST0001", new DateTime(2001, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern Ha Noi" },
                    { "ACCT0003", "Trading For New Customer 2", "CUST0002", new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Western Hai Phong" },
                    { "ACCT0004", "Saving For New Customer 3", "CUST0003", new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Western Hai Phong" },
                    { "ACCT0005", "Forex For New Customer 3", "CUST0003", new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Northern Hung Yen" },
                    { "ACCT0006", "Trading For New Customer 4", "CUST0004", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Northern Hung Yen" },
                    { "ACCT0007", "Trading For New Customer 4", "CUST0004", new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Southern Hai Duong" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccounts_CustomerID",
                table: "CustomerAccounts",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerAccounts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
