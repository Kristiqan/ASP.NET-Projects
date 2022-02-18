using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerShopProject.Migrations
{
    public partial class AddFlowerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flowers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowerName = table.Column<string>(nullable: true),
                    FlowerFamily = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    ShippingAddress = table.Column<string>(nullable: true),
                    ShippingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flowers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flowers");
        }
    }
}
