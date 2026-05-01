using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace homeworkFromTg.Migrations
{
    /// <inheritdoc />
    public partial class AddSelectionItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentLike_CharacterComment_CharacterCommentId",
                table: "CommentLike");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLike_EpisodeComment_EpisodeCommentId",
                table: "CommentLike");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLike_SelectionComment_SelectionCommentId",
                table: "CommentLike");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLike_StaffComment_StaffCommentId",
                table: "CommentLike");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLike_TitleComment_TitleCommentId",
                table: "CommentLike");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLike_UserComment_UserCommentId",
                table: "CommentLike");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLike_User_UserId",
                table: "CommentLike");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommentLike",
                table: "CommentLike");

            migrationBuilder.DropIndex(
                name: "IX_CommentLike_CharacterCommentId",
                table: "CommentLike");

            migrationBuilder.DropIndex(
                name: "IX_CommentLike_EpisodeCommentId",
                table: "CommentLike");

            migrationBuilder.DropIndex(
                name: "IX_CommentLike_SelectionCommentId",
                table: "CommentLike");

            migrationBuilder.DropIndex(
                name: "IX_CommentLike_StaffCommentId",
                table: "CommentLike");

            migrationBuilder.DropIndex(
                name: "IX_CommentLike_TitleCommentId",
                table: "CommentLike");

            migrationBuilder.DropColumn(
                name: "CharacterCommentId",
                table: "CommentLike");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "CommentLike");

            migrationBuilder.DropColumn(
                name: "EpisodeCommentId",
                table: "CommentLike");

            migrationBuilder.DropColumn(
                name: "SelectionCommentId",
                table: "CommentLike");

            migrationBuilder.DropColumn(
                name: "StaffCommentId",
                table: "CommentLike");

            migrationBuilder.DropColumn(
                name: "TitleCommentId",
                table: "CommentLike");

            migrationBuilder.RenameTable(
                name: "CommentLike",
                newName: "UserCommentLike");

            migrationBuilder.RenameIndex(
                name: "IX_CommentLike_UserId",
                table: "UserCommentLike",
                newName: "IX_UserCommentLike_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CommentLike_UserCommentId",
                table: "UserCommentLike",
                newName: "IX_UserCommentLike_UserCommentId");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserCommentId",
                table: "UserCommentLike",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCommentLike",
                table: "UserCommentLike",
                columns: new[] { "CommentId", "UserId" });

            migrationBuilder.CreateTable(
                name: "CharacterCommentLike",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsLiked = table.Column<bool>(type: "boolean", nullable: false),
                    CharacterCommentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterCommentLike", x => new { x.CommentId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CharacterCommentLike_CharacterComment_CharacterCommentId",
                        column: x => x.CharacterCommentId,
                        principalTable: "CharacterComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterCommentLike_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EpisodeCommentLike",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsLiked = table.Column<bool>(type: "boolean", nullable: false),
                    EpisodeCommentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpisodeCommentLike", x => new { x.CommentId, x.UserId });
                    table.ForeignKey(
                        name: "FK_EpisodeCommentLike_EpisodeComment_EpisodeCommentId",
                        column: x => x.EpisodeCommentId,
                        principalTable: "EpisodeComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EpisodeCommentLike_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SelectionCommentLike",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsLiked = table.Column<bool>(type: "boolean", nullable: false),
                    SelectionCommentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectionCommentLike", x => new { x.CommentId, x.UserId });
                    table.ForeignKey(
                        name: "FK_SelectionCommentLike_SelectionComment_SelectionCommentId",
                        column: x => x.SelectionCommentId,
                        principalTable: "SelectionComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectionCommentLike_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SelectionItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SelectionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Position = table.Column<int>(type: "integer", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "StaffCommentLike",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsLiked = table.Column<bool>(type: "boolean", nullable: false),
                    StaffCommentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffCommentLike", x => new { x.CommentId, x.UserId });
                    table.ForeignKey(
                        name: "FK_StaffCommentLike_StaffComment_StaffCommentId",
                        column: x => x.StaffCommentId,
                        principalTable: "StaffComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffCommentLike_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TitleCommentLike",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsLiked = table.Column<bool>(type: "boolean", nullable: false),
                    TitleCommentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleCommentLike", x => new { x.CommentId, x.UserId });
                    table.ForeignKey(
                        name: "FK_TitleCommentLike_TitleComment_TitleCommentId",
                        column: x => x.TitleCommentId,
                        principalTable: "TitleComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TitleCommentLike_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSelectionItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CharacterId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSelectionItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterSelectionItems_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSelectionItems_SelectionItem_Id",
                        column: x => x.Id,
                        principalTable: "SelectionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TitleSelectionItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TitleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleSelectionItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TitleSelectionItems_SelectionItem_Id",
                        column: x => x.Id,
                        principalTable: "SelectionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TitleSelectionItems_Title_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterCommentLike_CharacterCommentId",
                table: "CharacterCommentLike",
                column: "CharacterCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterCommentLike_UserId",
                table: "CharacterCommentLike",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSelectionItems_CharacterId",
                table: "CharacterSelectionItems",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeCommentLike_EpisodeCommentId",
                table: "EpisodeCommentLike",
                column: "EpisodeCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeCommentLike_UserId",
                table: "EpisodeCommentLike",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectionCommentLike_SelectionCommentId",
                table: "SelectionCommentLike",
                column: "SelectionCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectionCommentLike_UserId",
                table: "SelectionCommentLike",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectionItem_SelectionId",
                table: "SelectionItem",
                column: "SelectionId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffCommentLike_StaffCommentId",
                table: "StaffCommentLike",
                column: "StaffCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffCommentLike_UserId",
                table: "StaffCommentLike",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleCommentLike_TitleCommentId",
                table: "TitleCommentLike",
                column: "TitleCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleCommentLike_UserId",
                table: "TitleCommentLike",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleSelectionItems_TitleId",
                table: "TitleSelectionItems",
                column: "TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCommentLike_UserComment_UserCommentId",
                table: "UserCommentLike",
                column: "UserCommentId",
                principalTable: "UserComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCommentLike_User_UserId",
                table: "UserCommentLike",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCommentLike_UserComment_UserCommentId",
                table: "UserCommentLike");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCommentLike_User_UserId",
                table: "UserCommentLike");

            migrationBuilder.DropTable(
                name: "CharacterCommentLike");

            migrationBuilder.DropTable(
                name: "CharacterSelectionItems");

            migrationBuilder.DropTable(
                name: "EpisodeCommentLike");

            migrationBuilder.DropTable(
                name: "SelectionCommentLike");

            migrationBuilder.DropTable(
                name: "StaffCommentLike");

            migrationBuilder.DropTable(
                name: "TitleCommentLike");

            migrationBuilder.DropTable(
                name: "TitleSelectionItems");

            migrationBuilder.DropTable(
                name: "SelectionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCommentLike",
                table: "UserCommentLike");

            migrationBuilder.RenameTable(
                name: "UserCommentLike",
                newName: "CommentLike");

            migrationBuilder.RenameIndex(
                name: "IX_UserCommentLike_UserId",
                table: "CommentLike",
                newName: "IX_CommentLike_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCommentLike_UserCommentId",
                table: "CommentLike",
                newName: "IX_CommentLike_UserCommentId");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserCommentId",
                table: "CommentLike",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterCommentId",
                table: "CommentLike",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "CommentLike",
                type: "character varying(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "EpisodeCommentId",
                table: "CommentLike",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SelectionCommentId",
                table: "CommentLike",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StaffCommentId",
                table: "CommentLike",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TitleCommentId",
                table: "CommentLike",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommentLike",
                table: "CommentLike",
                columns: new[] { "CommentId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_CommentLike_CharacterCommentId",
                table: "CommentLike",
                column: "CharacterCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLike_EpisodeCommentId",
                table: "CommentLike",
                column: "EpisodeCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLike_SelectionCommentId",
                table: "CommentLike",
                column: "SelectionCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLike_StaffCommentId",
                table: "CommentLike",
                column: "StaffCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLike_TitleCommentId",
                table: "CommentLike",
                column: "TitleCommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLike_CharacterComment_CharacterCommentId",
                table: "CommentLike",
                column: "CharacterCommentId",
                principalTable: "CharacterComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLike_EpisodeComment_EpisodeCommentId",
                table: "CommentLike",
                column: "EpisodeCommentId",
                principalTable: "EpisodeComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLike_SelectionComment_SelectionCommentId",
                table: "CommentLike",
                column: "SelectionCommentId",
                principalTable: "SelectionComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLike_StaffComment_StaffCommentId",
                table: "CommentLike",
                column: "StaffCommentId",
                principalTable: "StaffComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLike_TitleComment_TitleCommentId",
                table: "CommentLike",
                column: "TitleCommentId",
                principalTable: "TitleComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLike_UserComment_UserCommentId",
                table: "CommentLike",
                column: "UserCommentId",
                principalTable: "UserComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLike_User_UserId",
                table: "CommentLike",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
