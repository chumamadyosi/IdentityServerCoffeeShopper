using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddCoffeeShops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO CoffeeShopS (Name,OpeningHours, Address) VALUES('PJ','9-6 Mon-Sat','2 Bemlont Terrace, Linkside, GP')");

            migrationBuilder.Sql($"INSERT INTO CoffeeShopS (Name,OpeningHours, Address) VALUES('Project ZA','9-6 Mon-Sat','3 Bemlont Terrace, Linkside, GP')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShopS (Name,OpeningHours, Address) VALUES('Lounge 010','9-6 Mon-Sat','4 Bemlont Terrace, Linkside, GP')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShopS (Name,OpeningHours, Address) VALUES('Y2K','9-6 Mon-Sat','5 Bemlont Terrace, Linkside, GP')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShopS (Name,OpeningHours, Address) VALUES('BUCCS','9-6 Mon-Sat','6 Bemlont Terrace, Linkside, GP')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShopS (Name,OpeningHours, Address) VALUES('BEER SHACK','9-6 Mon-Sat','7 Bemlont Terrace, Linkside, GP')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
