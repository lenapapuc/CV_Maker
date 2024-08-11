using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Maker.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstModels2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_CVs_СVId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_СVId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "СVId",
                table: "Skills");

            migrationBuilder.CreateTable(
                name: "SkillСV",
                columns: table => new
                {
                    CVsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillСV", x => new { x.CVsId, x.SkillsId });
                    table.ForeignKey(
                        name: "FK_SkillСV_CVs_CVsId",
                        column: x => x.CVsId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillСV_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillСV_SkillsId",
                table: "SkillСV",
                column: "SkillsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillСV");

            migrationBuilder.AddColumn<Guid>(
                name: "СVId",
                table: "Skills",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_СVId",
                table: "Skills",
                column: "СVId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_CVs_СVId",
                table: "Skills",
                column: "СVId",
                principalTable: "CVs",
                principalColumn: "Id");
        }
    }
}
