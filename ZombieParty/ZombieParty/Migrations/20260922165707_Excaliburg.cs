using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    /// <inheritdoc />
    public partial class Excaliburg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "WeaponId", "CreatedDate", "Description", "Force", "Image", "Name", "Price", "Qty", "QtyBought" },
                values: new object[] { 3, new DateTime(1000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "La espada de los mil caidos", 1000m, "https://img.magnific.com/premium-psd/excalibur-sword-stone-isolated-transparent-background_879541-1688.jpg", "Excaliburg", 550m, 6, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 3);
        }
    }
}
