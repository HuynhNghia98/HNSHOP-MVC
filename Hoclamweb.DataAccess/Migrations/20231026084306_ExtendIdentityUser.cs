using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suitshop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ExtendIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 520, DateTimeKind.Local).AddTicks(9630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 651, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 521, DateTimeKind.Local).AddTicks(974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 652, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 520, DateTimeKind.Local).AddTicks(9893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 651, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "ProductDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 521, DateTimeKind.Local).AddTicks(194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 651, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 521, DateTimeKind.Local).AddTicks(756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 651, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 521, DateTimeKind.Local).AddTicks(472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 651, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 520, DateTimeKind.Local).AddTicks(9259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 651, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "AspNetUsers",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 651, DateTimeKind.Local).AddTicks(8963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 520, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 652, DateTimeKind.Local).AddTicks(183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 521, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 651, DateTimeKind.Local).AddTicks(9235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 520, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "ProductDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 651, DateTimeKind.Local).AddTicks(9493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 521, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 651, DateTimeKind.Local).AddTicks(9978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 521, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 651, DateTimeKind.Local).AddTicks(9726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 521, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 26, 15, 13, 45, 651, DateTimeKind.Local).AddTicks(8586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 26, 15, 43, 6, 520, DateTimeKind.Local).AddTicks(9259));
        }
    }
}
