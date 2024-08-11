using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Maker.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstModels1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_CVs_СVId",
                table: "Skills");

            migrationBuilder.AlterColumn<Guid>(
                name: "СVId",
                table: "Skills",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_CVs_СVId",
                table: "Skills",
                column: "СVId",
                principalTable: "CVs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_CVs_СVId",
                table: "Skills");

            migrationBuilder.AlterColumn<Guid>(
                name: "СVId",
                table: "Skills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_CVs_СVId",
                table: "Skills",
                column: "СVId",
                principalTable: "CVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
