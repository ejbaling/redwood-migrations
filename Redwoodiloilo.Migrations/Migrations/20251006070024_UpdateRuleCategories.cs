using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Redwoodiloilo.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRuleCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rules_Categories_RuleCategoryId",
                table: "Rules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "RuleCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RuleCategories",
                table: "RuleCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rules_RuleCategories_RuleCategoryId",
                table: "Rules",
                column: "RuleCategoryId",
                principalTable: "RuleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rules_RuleCategories_RuleCategoryId",
                table: "Rules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RuleCategories",
                table: "RuleCategories");

            migrationBuilder.RenameTable(
                name: "RuleCategories",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rules_Categories_RuleCategoryId",
                table: "Rules",
                column: "RuleCategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
