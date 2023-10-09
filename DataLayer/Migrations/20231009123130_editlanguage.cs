using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class editlanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Language_AboutWebsite_AboutId",
                table: "Language");

            migrationBuilder.DropIndex(
                name: "IX_Language_AboutId",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "Language");

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "AboutWebsite",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutWebsite",
                keyColumn: "Id",
                keyValue: 1,
                column: "LanguageId",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AboutWebsite_LanguageId",
                table: "AboutWebsite",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutWebsite_Language_LanguageId",
                table: "AboutWebsite",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutWebsite_Language_LanguageId",
                table: "AboutWebsite");

            migrationBuilder.DropIndex(
                name: "IX_AboutWebsite_LanguageId",
                table: "AboutWebsite");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "AboutWebsite");

            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "Language",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Language_AboutId",
                table: "Language",
                column: "AboutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Language_AboutWebsite_AboutId",
                table: "Language",
                column: "AboutId",
                principalTable: "AboutWebsite",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
