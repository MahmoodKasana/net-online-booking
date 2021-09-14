using Microsoft.EntityFrameworkCore.Migrations;

namespace NetOnlineBooking.Migrations
{
    public partial class addressfieldcreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Booking");
        }
    }
}
