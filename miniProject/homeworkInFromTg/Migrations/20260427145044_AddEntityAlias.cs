using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace homeworkFromTg.Migrations
{
    /// <inheritdoc />
    public partial class AddEntityAlias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSelectionItems_SelectionItem_Id",
                table: "CharacterSelectionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TitleSelectionItems_SelectionItem_Id",
                table: "TitleSelectionItems");

            migrationBuilder.DropTable(
                name: "SelectionItem");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedAt",
                table: "TitleSelectionItems",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "TitleSelectionItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "SelectionId",
                table: "TitleSelectionItems",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedAt",
                table: "CharacterSelectionItems",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "CharacterSelectionItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "SelectionId",
                table: "CharacterSelectionItems",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "TitleAlias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TitleId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    LanguageCode = table.Column<string>(type: "text", nullable: true),
                    IsOfficial = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleAlias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TitleAlias_Title_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TitleSelectionItems_SelectionId",
                table: "TitleSelectionItems",
                column: "SelectionId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSelectionItems_SelectionId",
                table: "CharacterSelectionItems",
                column: "SelectionId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleAlias_TitleId",
                table: "TitleAlias",
                column: "TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSelectionItems_Selection_SelectionId",
                table: "CharacterSelectionItems",
                column: "SelectionId",
                principalTable: "Selection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TitleSelectionItems_Selection_SelectionId",
                table: "TitleSelectionItems",
                column: "SelectionId",
                principalTable: "Selection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSelectionItems_Selection_SelectionId",
                table: "CharacterSelectionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TitleSelectionItems_Selection_SelectionId",
                table: "TitleSelectionItems");

            migrationBuilder.DropTable(
                name: "TitleAlias");

            migrationBuilder.DropIndex(
                name: "IX_TitleSelectionItems_SelectionId",
                table: "TitleSelectionItems");

            migrationBuilder.DropIndex(
                name: "IX_CharacterSelectionItems_SelectionId",
                table: "CharacterSelectionItems");

            migrationBuilder.DropColumn(
                name: "AddedAt",
                table: "TitleSelectionItems");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "TitleSelectionItems");

            migrationBuilder.DropColumn(
                name: "SelectionId",
                table: "TitleSelectionItems");

            migrationBuilder.DropColumn(
                name: "AddedAt",
                table: "CharacterSelectionItems");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "CharacterSelectionItems");

            migrationBuilder.DropColumn(
                name: "SelectionId",
                table: "CharacterSelectionItems");

            migrationBuilder.CreateTable(
                name: "SelectionItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SelectionId = table.Column<Guid>(type: "uuid", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Position = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectionItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectionItem_Selection_SelectionId",
                        column: x => x.SelectionId,
                        principalTable: "Selection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SelectionItem_SelectionId",
                table: "SelectionItem",
                column: "SelectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSelectionItems_SelectionItem_Id",
                table: "CharacterSelectionItems",
                column: "Id",
                principalTable: "SelectionItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TitleSelectionItems_SelectionItem_Id",
                table: "TitleSelectionItems",
                column: "Id",
                principalTable: "SelectionItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
