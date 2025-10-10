using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KairaCQRSMediator.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_photogallery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhotoGalleries",
                columns: table => new
                {
                    PhotoGalleryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoGalleries", x => x.PhotoGalleryId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhotoGalleries");
        }
    }
}
