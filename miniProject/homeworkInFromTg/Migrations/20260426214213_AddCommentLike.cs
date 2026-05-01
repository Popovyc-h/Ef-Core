using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace homeworkFromTg.Migrations
{
    /// <inheritdoc />
    public partial class AddCommentLike : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommentLike",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsLiked = table.Column<bool>(type: "boolean", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(21)", maxLength: 21, nullable: false),
                    CharacterCommentId = table.Column<Guid>(type: "uuid", nullable: true),
                    EpisodeCommentId = table.Column<Guid>(type: "uuid", nullable: true),
                    SelectionCommentId = table.Column<Guid>(type: "uuid", nullable: true),
                    StaffCommentId = table.Column<Guid>(type: "uuid", nullable: true),
                    TitleCommentId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserCommentId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentLike", x => new { x.CommentId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CommentLike_CharacterComment_CharacterCommentId",
                        column: x => x.CharacterCommentId,
                        principalTable: "CharacterComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentLike_EpisodeComment_EpisodeCommentId",
                        column: x => x.EpisodeCommentId,
                        principalTable: "EpisodeComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentLike_SelectionComment_SelectionCommentId",
                        column: x => x.SelectionCommentId,
                        principalTable: "SelectionComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentLike_StaffComment_StaffCommentId",
                        column: x => x.StaffCommentId,
                        principalTable: "StaffComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentLike_TitleComment_TitleCommentId",
                        column: x => x.TitleCommentId,
                        principalTable: "TitleComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentLike_UserComment_UserCommentId",
                        column: x => x.UserCommentId,
                        principalTable: "UserComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentLike_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CommentLike_UserCommentId",
                table: "CommentLike",
                column: "UserCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLike_UserId",
                table: "CommentLike",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentLike");
        }
    }
}
