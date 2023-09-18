using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class TestAbout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Socials",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifyBy",
                table: "Socials",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Slides",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifyBy",
                table: "Slides",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifyBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "ProductImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ProductImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifyBy",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifyBy",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "OnlineSells",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "OnlineSells",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "OnlineSells",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifyBy",
                table: "OnlineSells",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Navs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Navs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Navs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifyBy",
                table: "Navs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifyBy",
                table: "contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "contactForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "contactForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "contactForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifyBy",
                table: "contactForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AboutWebsite",
                columns: new[] { "Id", "Description", "ImageFileName", "Title" },
                values: new object[] { 1, "Description", "Title", "Title" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AboutWebsite",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Socials");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Socials");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Socials");

            migrationBuilder.DropColumn(
                name: "ModifyBy",
                table: "Socials");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "ModifyBy",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ModifyBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ModifyBy",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "ModifyBy",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "OnlineSells");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "OnlineSells");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "OnlineSells");

            migrationBuilder.DropColumn(
                name: "ModifyBy",
                table: "OnlineSells");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Navs");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Navs");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Navs");

            migrationBuilder.DropColumn(
                name: "ModifyBy",
                table: "Navs");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "ModifyBy",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "contactForms");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "contactForms");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "contactForms");

            migrationBuilder.DropColumn(
                name: "ModifyBy",
                table: "contactForms");
        }
    }
}
