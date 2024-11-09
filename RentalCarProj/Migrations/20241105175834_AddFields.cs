using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentalCarProj.Migrations
{
    /// <inheritdoc />
    public partial class AddFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentDuration",
                table: "Rents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "AppUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SerialNumber",
                table: "AppUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: "Admin123",
                columns: new[] { "Balance", "SerialNumber" },
                values: new object[] { 0.0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentDuration",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "AppUsers");
        }
    }
}
