using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Notes_WebApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldIsEditing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEditing",
                table: "Notes",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEditing",
                table: "Notes");
        }
    }
}
