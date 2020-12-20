using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackMyBooks.Migrations
{
    public partial class ChangedDateTimeOffSetToDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateReturned",
                table: "Book",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCheckedOut",
                table: "Book",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateReturned",
                table: "Book",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCheckedOut",
                table: "Book",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
