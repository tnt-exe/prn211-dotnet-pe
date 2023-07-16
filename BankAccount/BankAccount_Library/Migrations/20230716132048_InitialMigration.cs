using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankAccount_Library.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountTypes",
                columns: table => new
                {
                    TypeID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    TypeDesc = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AccountT__516F039556304D38", x => x.TypeID);
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
                name: "BankAccounts",
                columns: table => new
                {
                    AccountID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    OpenDate = table.Column<DateTime>(type: "date", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TypeID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BankAcco__349DA586AF9250C9", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK__BankAccou__TypeI__286302EC",
                        column: x => x.TypeID,
                        principalTable: "AccountTypes",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccountTypes",
                columns: new[] { "TypeID", "TypeDesc", "TypeName" },
                values: new object[,]
                {
                    { "AT0001", "Saving Account Description", "Saving" },
                    { "AT0002", "Checking Account Description", "Checking" },
                    { "AT0003", "Trading Account Description", "Trading" },
                    { "AT0004", "Money Market Account Description", "Forex" }
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
                table: "BankAccounts",
                columns: new[] { "AccountID", "AccountName", "BranchName", "OpenDate", "TypeID" },
                values: new object[,]
                {
                    { "ACCT0001", "Saving For New Customer 1", "Ha Noi", new DateTime(2001, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AT0001" },
                    { "ACCT0002", "Checking For New Customer 2", "Ha Noi", new DateTime(2001, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AT0002" },
                    { "ACCT0003", "Trading For New Customer 3", "Ha Noi", new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AT0003" },
                    { "ACCT0004", "Saving For New Customer 4", "HCM", new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AT0001" },
                    { "ACCT0005", "Forex For New Customer 5", "HCM", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AT0004" },
                    { "ACCT0006", "Trading For New Customer 6", "Hai Phong", new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AT0003" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_TypeID",
                table: "BankAccounts",
                column: "TypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AccountTypes");
        }
    }
}
