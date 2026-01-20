using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Redwoodiloilo.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRuleCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rules_Categories_CategoryId",
                table: "Rules");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Rules",
                newName: "RuleCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Rules_CategoryId",
                table: "Rules",
                newName: "IX_Rules_RuleCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rules_Categories_RuleCategoryId",
                table: "Rules",
                column: "RuleCategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rules_Categories_RuleCategoryId",
                table: "Rules");

            migrationBuilder.RenameColumn(
                name: "RuleCategoryId",
                table: "Rules",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Rules_RuleCategoryId",
                table: "Rules",
                newName: "IX_Rules_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rules_Categories_CategoryId",
                table: "Rules",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
