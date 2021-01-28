using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroCreator.Data.Migrations
{
    public partial class superherodatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperHero");

            migrationBuilder.CreateTable(
                name: "SuperHeros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AlterEgo = table.Column<string>(nullable: true),
                    PrimaryAbility = table.Column<string>(nullable: true),
                    SecondaryAbility = table.Column<string>(nullable: true),
                    CatchPhrase = table.Column<string>(nullable: true),
                    HeroImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHeros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperHeros");

            migrationBuilder.CreateTable(
                name: "SuperHero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlterEgo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatchPhrase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryAbility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryAbility = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHero", x => x.Id);
                });
        }
    }
}
