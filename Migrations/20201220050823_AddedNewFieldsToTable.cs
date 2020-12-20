using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackMyBooks.Migrations
{
    public partial class AddedNewFieldsToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateCheckedOut",
                table: "Book",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateReturned",
                table: "Book",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "DateCheckedOut",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "DateReturned",
                table: "Book");
        }
    }
}
