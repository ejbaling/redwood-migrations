using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Redwoodiloilo.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConfigValueType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Step 1: Convert existing data to boolean explicitly using PostgreSQL cast
            migrationBuilder.Sql("""
                ALTER TABLE "Configs"
                ALTER COLUMN "Value" TYPE boolean
                USING CASE
                    WHEN "Value" IN ('true', '1', 'yes', 'enabled', 'True', 'TRUE') THEN TRUE
                    ELSE FALSE
                END;
            """);

            // Step 2: Set default + constraints
            migrationBuilder.Sql("""
                UPDATE "Configs" SET "Value" = FALSE WHERE "Value" IS NULL;
                ALTER TABLE "Configs" ALTER COLUMN "Value" SET NOT NULL;
                ALTER TABLE "Configs" ALTER COLUMN "Value" SET DEFAULT FALSE;
            """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                ALTER TABLE "Configs"
                ALTER COLUMN "Value" DROP DEFAULT;
                ALTER TABLE "Configs"
                ALTER COLUMN "Value" TYPE text
                USING CASE
                    WHEN "Value" = TRUE THEN 'true'
                    ELSE 'false'
                END;
                ALTER TABLE "Configs" ALTER COLUMN "Value" DROP NOT NULL;
            """);
        }
    }
}
