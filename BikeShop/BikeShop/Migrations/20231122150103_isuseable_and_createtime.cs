using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeShop.Migrations
{
    public partial class isuseable_and_createtime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "brands",
                newName: "name");

            migrationBuilder.AddColumn<DateTime>(
                name: "CREATETIME",
                table: "categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 0, 1, 2, 948, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.AddColumn<string>(
                name: "ISUSEABLE",
                table: "categories",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CREATETIME",
                table: "brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 0, 1, 2, 948, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.AddColumn<string>(
                name: "ISUSEABLE",
                table: "brands",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CREATETIME",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "ISUSEABLE",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "CREATETIME",
                table: "brands");

            migrationBuilder.DropColumn(
                name: "ISUSEABLE",
                table: "brands");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "brands",
                newName: "Name");
        }
    }
}
