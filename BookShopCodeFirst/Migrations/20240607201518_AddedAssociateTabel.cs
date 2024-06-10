using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddedAssociateTabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TyBookAwards",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AwardId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TyBookAwards", x => new { x.BookId, x.AwardId });
                    table.ForeignKey(
                        name: "FK_TyBookAwards_Awards_AwardId",
                        column: x => x.AwardId,
                        principalTable: "Awards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TyBookAwards_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TyBookAwards_AwardId",
                table: "TyBookAwards",
                column: "AwardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TyBookAwards");
        }
    }
}
