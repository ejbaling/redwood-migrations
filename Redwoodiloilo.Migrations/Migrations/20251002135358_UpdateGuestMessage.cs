using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Redwoodiloilo.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGuestMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "GuestMessages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "GuestMessages",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "GuestMessages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReplySuggestion",
                table: "GuestMessages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sentiment",
                table: "GuestMessages",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "GuestMessages");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "GuestMessages");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "GuestMessages");

            migrationBuilder.DropColumn(
                name: "ReplySuggestion",
                table: "GuestMessages");

            migrationBuilder.DropColumn(
                name: "Sentiment",
                table: "GuestMessages");

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });
        }
    }
}
