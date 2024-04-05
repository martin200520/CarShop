using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "Brand", "HorsePower", "Model", "Price", "Year" },
                values: new object[,]
                {
                    { 1, "Toyota", 203, "Camry", 25000m, 2020 },
                    { 2, "Honda", 192, "Accord", 27000m, 2021 },
                    { 3, "Chevrolet", 160, "Malibu", 28000m, 2019 },
                    { 4, "Ford", 175, "Fusion", 26000m, 2018 },
                    { 5, "Hyundai", 191, "Sonata", 24500m, 2020 },
                    { 6, "Kia", 185, "Optima", 25500m, 2019 },
                    { 7, "Nissan", 188, "Altima", 27500m, 2021 },
                    { 8, "Mazda", 187, "Mazda6", 26500m, 2020 },
                    { 9, "Subaru", 182, "Legacy", 27000m, 2019 },
                    { 10, "Volkswagen", 174, "Passat", 29000m, 2021 },
                    { 11, "BMW", 255, "3 Series", 40000m, 2020 },
                    { 12, "Mercedes-Benz", 255, "C-Class", 42000m, 2019 },
                    { 13, "Audi", 201, "A4", 38000m, 2021 },
                    { 14, "Lexus", 203, "ES", 39000m, 2020 },
                    { 15, "Tesla", 283, "Model 3", 48000m, 2021 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");
        }
    }
}
