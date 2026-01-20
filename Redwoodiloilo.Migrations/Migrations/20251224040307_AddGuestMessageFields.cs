using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Redwoodiloilo.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddGuestMessageFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AirbnbId",
                table: "GuestMessages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookingId",
                table: "GuestMessages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "GuestMessages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "GuestMessages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "GuestMessages",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirbnbId",
                table: "GuestMessages");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "GuestMessages");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "GuestMessages");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "GuestMessages");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "GuestMessages");
        }
    }
}
