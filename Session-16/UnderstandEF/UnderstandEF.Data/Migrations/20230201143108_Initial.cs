using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnderstandEF.Orm.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "POET",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POET", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Poem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoemBody = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    PoemName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PoetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Poem_POET_PoetID",
                        column: x => x.PoetID,
                        principalTable: "POET",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Poem_PoetID",
                table: "Poem",
                column: "PoetID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Poem");

            migrationBuilder.DropTable(
                name: "POET");
        }
    }
}
