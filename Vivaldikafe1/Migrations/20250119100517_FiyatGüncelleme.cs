using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivaldikafe1.Migrations
{
    /// <inheritdoc />
    public partial class FiyatGüncelleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ucret",
                table: "sogukKahves",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ucret",
                table: "sogukKahves");
        }
    }
}
