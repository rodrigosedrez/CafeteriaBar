using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeteriaFaculnet7.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtoss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ImageSource = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtoss", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Produtoss",
                columns: new[] { "Id", "Description", "ImageSource", "Name" },
                values: new object[] { 1, "Café tradicional passado e suave.", " ", "Café Preto" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtoss");
        }
    }
}
