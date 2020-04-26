using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeAppV3.Migrations
{
    public partial class MoreAttributestoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecipeIngredients",
                table: "Recipes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RecipeTime",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipeIngredients",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "RecipeTime",
                table: "Recipes");
        }
    }
}
