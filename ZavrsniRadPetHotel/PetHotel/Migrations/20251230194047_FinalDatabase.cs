using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetHotel.Migrations
{
    /// <inheritdoc />
    public partial class FinalDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Pets_PetId",
                table: "Bookings");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Pets_PetId",
                table: "Bookings",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Pets_PetId",
                table: "Bookings");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Pets_PetId",
                table: "Bookings",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
