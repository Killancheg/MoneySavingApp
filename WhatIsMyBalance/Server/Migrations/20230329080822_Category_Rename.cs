using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhatIsMyBalance.Server.Migrations
{
    /// <inheritdoc />
    public partial class Category_Rename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BalanceChanges_BalanceChangeCategories_CategoryId",
                table: "BalanceChanges");

            migrationBuilder.DropTable(
                name: "BalanceChangeCategories");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsIncome = table.Column<bool>(type: "bit", nullable: false),
                    IconId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BalanceChanges_Categories_CategoryId",
                table: "BalanceChanges",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BalanceChanges_Categories_CategoryId",
                table: "BalanceChanges");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.CreateTable(
                name: "BalanceChangeCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconId = table.Column<int>(type: "int", nullable: false),
                    IsIncome = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceChangeCategories", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BalanceChanges_BalanceChangeCategories_CategoryId",
                table: "BalanceChanges",
                column: "CategoryId",
                principalTable: "BalanceChangeCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
