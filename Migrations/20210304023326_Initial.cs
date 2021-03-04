using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment5.Migrations
{
    //This is where the Initial migration is created and connected to sqlite
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    Publisher = table.Column<string>(type: "TEXT", nullable: true),
                    ISBN = table.Column<string>(type: "TEXT", nullable: true),
                    Classification = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    PageNumbers = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.BookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
