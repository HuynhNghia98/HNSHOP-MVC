using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suitshop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoryAndSubCateegory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlName",
                table: "SubCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UrlName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlName",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "UrlName",
                table: "Categories");
        }
    }
}
